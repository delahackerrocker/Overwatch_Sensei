# Overwatch Sensei revival audit

Inspected September 30, 2026. This is a source inspection, not a successful Unity import or device test.

Follow-up: the reachable origin is https://github.com/delahackerrocker/Overwatch_Sensei.git.
The checkout was three commits behind origin/main and has been fast-forwarded to
`beeab97` ("Bundle ID Added"). That newer baseline already records Unity
6000.2.6f2 and updates packages/TMP assets. The initial 2021.3 observations below
describe the original local checkout. App navigation and ability scripts were
unchanged by those three commits. Device builds are deferred at the owner's request.

## Product constraints

- A mobile companion used while playing Overwatch, with hero stats, abilities, matchup advice, and counter picks.
- Preserve the original swipe navigation and its feel. The owner explicitly values this interaction.
- Start with landscape across phones and tablets; portrait is outside the first migration.
- Refresh content using public sources and make future updates easier to maintain.

## Baseline

- Project: `GIT/Overwatch_Sensei` under the workspace root.
- Recorded editor: Unity 2021.3.6f1, revision `7da38d85baf6`.
- Latest existing commit inspected: `b515e35`, "Tweaked some things for screen size".
- Git worktree was clean before this audit was added.
- Installed editors: 6000.5.7f1 and 6000.6.0f1.
- The inspected 6000.6.0f1 PlaybackEngines directory contains Windows standalone support only. Android/iOS build support must be checked and provisioned before those builds can be verified.
- Main build scene: `Assets/Sensei/Scenes/Main.unity`.
- UI uses Canvas/uGUI, TextMesh Pro, EventSystem drag handlers, and bundled DOTween.
- Existing content includes 32 hero constructors, 1,024 matchup text files, and 208 MP4 files under StreamingAssets. File counts do not establish that every file contains usable or current content.

## Navigation behavior to preserve

Source: `Assets/Sensei/Script/PanelNavigation.cs`, `PanelNode.cs`, and the serialized main scene.

- Panels form an explicit graph with above/below/left/right references.
- Drag follows pointer displacement, constrained by whether the current node has a neighbor on each axis.
- Release chooses the dominant axis using displacement divided by the design panel width/height.
- Transitions use DOTween, 0.5 seconds, `Ease.OutQuint`, with snapping enabled.
- The main scene serializes `percentThreshold: 0`; the code initializer is `25f`. The scene's actual value is the compatibility baseline. Do not silently replace it with a 25% threshold.
- The EventSystem serializes `m_DragThreshold: 10`.
- Opponent panels and the next-ability panel use callbacks to cycle content and return to the central display. These are part of the navigation behavior.
- Returning to PickHero clears the selected hero/opponent; returning to HeroTasks clears the opponent.

Serialized graph (directions are neighbor fields, not finger movement):

| Panel | Above | Below | Left | Right |
| --- | --- | --- | --- | --- |
| PickHero | — | — | — | — |
| HeroTasks | PickHero | HeroVersusHero | HeroKit | HeroCounterPicks |
| HeroKit | PickHero | — | — | HeroTasks |
| HeroAbilityDetails | PickHero | — | NextHeroAbilityDetails | HeroKit |
| HeroCounterPicks | PickHero | — | HeroTasks | — |
| HeroVersusHero | HeroTasks | — | HeroVersusHero_Previous | HeroVersusHero_Next |
| HeroVersusHero_Previous | HeroTasks | — | HeroVersusHero_Previous | HeroVersusHero_Next |
| HeroVersusHero_Next | HeroTasks | — | HeroVersusHero_Previous | HeroVersusHero_Next |
| NextHeroAbilityDetails | — | — | — | NextHeroAbilityDetails |

Buttons supply additional routes. Preserve their serialized callbacks as well as the graph.

## Screen-size findings

- Navigation uses hard-coded 2340 x 1080 panel dimensions and absolute world-space destinations such as (1170, 540).
- The CanvasScaler uses Constant Pixel Size (`m_UiScaleMode: 0`), scale factor 1. Its unused reference resolution is 800 x 600.
- Panel RectTransforms have fixed 2340 x 1080 sizes. Several panel offsets differ slightly from the hard-coded destinations.
- Raw screen-pointer movement and absolute transform positions are coupled. Changing CanvasScaler alone would not make the navigation resolution independent.
- No safe-area handling was found in the app scripts inspected.
- `_lastPointerData` is declared and read by CancelDrag but never assigned in PanelNavigation. Transitions also do not explicitly replace an active navigation tween. Interrupting transitions needs regression coverage before changing that behavior.

The original 2340 x 1080 view should serve as the behavior baseline. Validation needs narrower landscape phones, wider phones, tablets, safe-area insets, and resizing while a drag or transition is active. Text must remain readable; simply shrinking the entire phone layout is not sufficient evidence of tablet support.

## Migration and runtime findings

The package manifest includes old versions of Collab Proxy, IDE integrations, Shader Graph, TextMesh Pro, Adaptive Performance, Timeline, and Visual Scripting. These require a dependency/usage audit and editor import diagnostics. Their age alone does not prove they are broken.

Retain uGUI and the current gesture implementation for the first migration. The inspected source does not establish a need to replace the UI framework or the navigation graph.

Two existing runtime problems deserve focused repair and verification:

- `HeroAbilityDetails.Update` stops and prepares the video and adds another prepareCompleted subscription every frame. It also prepends `file://` to StreamingAssets paths without platform-specific handling, and logs a stale F: drive path.
- `HeroKit.Update` clears selectedAbility whenever its hero-change condition is false, including while the ability detail screen is expected to use that selection. Runtime execution order and screen behavior must be checked.

No Unity import, compilation, play-mode test, Android build, or physical-device test was run during this audit. Compatibility errors remain unconfirmed until an editor import is performed.

## Content expansion findings

- Main allocates an array of exactly 32 heroes and initializes each through a separate C# constructor.
- HERO_ID is an implicitly numbered enum ending in None (32). Scene/prefab serialization and arrays depend on those numeric values. Adding heroes must preserve existing IDs, including None, or explicitly migrate every serialized reference.
- HeroVersusHero cycles opponents through enum arithmetic, bounded by Ana and Zenyatta.
- HeroMatchups selects text through hero-specific methods and integer indexing. Roster growth requires more than adding names to the enum.
- Hero portraits/icons are loaded from resource paths based on HERO_ID names. New roster entries need a deliberate asset/fallback policy.
- Existing numbers and matchup text should be treated as legacy until reviewed against a named live patch and game mode.

For a later content migration, keep hero facts separate from matchup advice. Record source URLs, verification dates, patch/mode context, and review status. Official hero pages and patch notes can substantiate hero changes; matchup recommendations need their own evidence and editorial review. Do not display unreviewed legacy advice as current.

## Public references checked

- Unity 6000.6.0f1 release notes (released August 31, 2026): https://unity.com/releases/editor/whats-new/6000.6.0f1
- Unity 6 upgrade guidance: https://docs.unity3d.com/6000.6/Documentation/Manual/UpgradeGuideUnity6.html
- Blizzard hero index: https://overwatch.blizzard.com/en-us/Heroes/
- Blizzard live patch notes: https://overwatch.blizzard.com/en-us/news/patch-notes/

The Blizzard index appeared in search results with heroes absent from the local 32-hero roster. Direct retrieval of the lower-case hero index and patch-notes page failed in the research tool. A complete, verified content import has not been performed.
