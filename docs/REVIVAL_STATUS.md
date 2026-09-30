# Unity revival — first pass

## Baseline and scope

Work starts from GitHub `origin/main` at `beeab97` (Bundle ID Added), after a fast-forward from the older local checkout. That commit already used Unity 6000.2.6f2. The current migration targets the installed Unity 6000.6.0f1 (`f7f8ed4d1e24`).

The app remains landscape on phones and tablets. Portrait, updated hero content, and device builds are separate follow-up work. No app packages have been built or published.

Unity's settings migration raised the recorded minimum OS versions to Android API 26 and iOS 15. Mobile modules are not installed on this machine; platform builds and device compatibility remain unverified.

## Navigation and layout

- Keep the original PanelNode graph and scene/button references.
- Keep the scene's zero fractional swipe threshold after the EventSystem's drag threshold, 0.5-second transition, OutQuint easing, and snapping.
- Convert screen pointer coordinates into the viewport's local coordinates. Destinations are based on actual panel locations rather than absolute screen pixels.
- Lay out the original panel arrangement against the available viewport. The original 2340 x 1080 design remains the minimum content area; taller displays receive more panel height.
- Place the navigation inside a clipped safe-area viewport. Recalculate after screen/safe-area changes and cancel stale gestures when the viewport changes.
- Stretch the background across the screen and anchor hero portraits and health displays inside the safe area's bottom corners.
- Replace an active navigation tween before starting another. Preserve the eased return at a missing neighbor and the immediate reset for short/tied gestures.

## Ability screens

- An unchanged HeroKit no longer clears the current ability every frame.
- Selecting an ability synchronizes the cycling index; selecting a new hero clears stale ability state.
- Ability videos update only when the selected hero/ability changes or the detail view is revisited. Event handlers subscribe once and unsubscribe on disable.
- Local clips use proper file URIs. Existing StreamingAssets URLs retain their scheme. Missing clips leave ability text available. Android video playback still needs device validation.
- Disable the scene's automatic video playback and remove its obsolete machine-specific startup URL; the selected ability controls playback.

## DOTween

The checkout contained core 1.2.632 and no DOTween Pro components were found. Core was updated in place to the publisher's 1.3.030 distribution. Existing Unity asset GUIDs and DOTweenSettings were retained. No replacement tween engine was introduced.

- Download and changelog: https://dotween.demigiant.com/download.php
- Upgrade procedure: https://dotween.demigiant.com/support.php
- Archive: https://dotween.demigiant.com/downloads/DOTween_1_3_030.zip
- Archive SHA-256: `62a0ececd274e1587eb0dea15f3afab392fbda5a0f8cac7287fbf7f64925a1ba`

Unity was closed during the replacement and restarted afterward. The editor helper applies the publisher's saved module settings. Paid Pro installation/updates, if wanted later, should come from the owner's Asset Store account and follow the publisher's compatibility instructions.

## Reproducible checks

Use the Unity 6000.6.0f1 editor executable with `-batchmode -projectPath <project>` and one of these `-executeMethod` values. These are editor checks, not player builds. Do not add `-quit` to the check/preview commands: the helpers exit after their work completes.

| Method | Purpose | Output |
| --- | --- | --- |
| `RevivalChecks.Run` | Coordinate scaling, drag cancellation, ability selection, swipe graph, resize, blocked-edge behavior, video subscriptions, and real-scene routes | `Logs/revival-checks.txt` |
| `RevivalPlayChecks.Run` | Real Play Mode rapid transitions, ability selection across frames, ability cycling, swipe routing and settling | `Logs/revival-play-checks.txt` |
| `RevivalPreviews.Run` | Apply landscape settings/module setup; render phone, tablet, and notched-phone layouts with native Unity UI | `Logs/Previews/*.png` |

Run with graphics enabled for Play Mode and previews. The old DOTween library intentionally skipped per-tween cancellation outside Play Mode; cancellation is therefore verified in Play Mode, rather than inferred from an editor-only simulation.

Logs and preview images are ignored local artifacts. The editor helpers remain in source so another machine can repeat the checks. A touch-device review is still required to assess subjective swipe feel, safe areas, text size, video decoding, and OS interruptions.

Verified locally on 2026-09-30: all 11 editor checks passed; six previews rendered across 2340 x 1080, 2048 x 1536, and 2400 x 1080 (with simulated safe-area insets). Play Mode verified DOTween 1.3.030, rapid transition cancellation, persistent ability selection, ability cycling, swipe routing/settling, and the health-display hierarchy. Editor simulations unpack prefab instances in memory to permit runtime reparenting; they do not save those changes to the scene.

The Play Mode log also contains an editor SearchDatabase indexing exception during the domain reload. Its stack is entirely in UnityEditor.Search; the app checks still finish successfully. This editor issue remains unresolved and the run should not be described as a completely clean log.

## Remaining content work

The app still contains the original 32-hero content. It must not be presented as current game data. A subsequent pass needs stable hero IDs, roster-driven cycling and selection, sourced/dated stats and abilities, and reviewed matchup advice tied to a patch and game mode. See REVIVAL_AUDIT.md for the original data dependencies.
