# Overwatch Sensei — Mac handoff

Prepared September 30, 2026. Read this before continuing the revival or making an iOS build.

## User and agreed direction

- The user goes by **Dela**, not Steve. They call the assistant Opal.
- This is Dela's Unity mobile companion for Overwatch: quick access to hero stats, abilities, matchups, and advice while playing.
- **Preserve the original swipe navigation.** Dela especially values how it feels. Keep the panel graph, snapping behavior, 0.5-second transitions, and OutQuint easing. Adapt coordinates and safe areas without redesigning the interaction.
- **Landscape only**, across phones and tablets. Both landscape orientations are enabled; portrait and upside-down portrait are disabled.
- **Keep DOTween.** Dela paid for it and wants to continue supporting its creator. Do not replace it with a custom tween engine without a new reason and discussion.
- Use public sources, including Blizzard's official site, for the eventual hero/stat/ability refresh. Do not invent matchup claims or present the old data as current.
- Respect the repository history across Dela's computers. The previous revival attempt explains the newer upstream Unity baseline.

## Current request and authorization

Dela has now asked to **make an iOS build and put it on TestFlight**. This supersedes the earlier instruction to defer device builds. The Windows session could not perform the Apple build/sign/upload steps, so Dela is moving to the Mac.

Continue toward a signed iOS archive and TestFlight upload once tools and account access are available. This does not authorize an App Store production release, purchases, or invitations to unspecified testers. Do not repeat general permission questions for the build/upload already requested. Ask only for genuinely missing account, signing, bundle identity, or distribution details.

## Repository and transfer

Repository: https://github.com/delahackerrocker/Overwatch_Sensei.git

Windows project root: `E:\Developer\Overwatch_App\GIT\Overwatch_Sensei`

Migration baseline: `beeab976a70098017fc79e1f9ca717ab41bb425f` (`Bundle ID Added`). The older Windows checkout was fetched and fast-forwarded to this upstream baseline before migration work.

Dela explicitly requested committing all revival changes together with this handoff. **The commit containing this file includes the Unity migration, DOTween update, navigation/ability fixes, new layout/check helpers, and the other revival documentation.** Earlier conversation statements that the work was uncommitted describe the state before this handoff commit.

On the Mac, fetch/pull the revival commit from `origin/main`, preserving any existing local changes. Verify that the commit is available remotely before assuming the handoff is synchronized. Do not redo the migration or copy over another checkout blindly. Use Git LFS if needed by existing repository assets.

Locate the actual Mac project path; do not reuse Windows absolute paths. Confirm Git status and these files before opening Unity: `Assets/Sensei/Script/LandscapeLayout.cs`, the three `Assets/Editor/Revival*.cs` helpers, and the new DOTween modules/DLLs. Do not transfer Windows-generated `Library`, `Temp`, `Obj`, or IDE caches. Ignored `Logs` contains local evidence/previews that can be regenerated with the committed helpers.

## Completed migration work

- Upstream already targeted Unity `6000.2.6f2`; the revival now targets **Unity `6000.6.0f1`**, revision `f7f8ed4d1e24`.
- Unity imported the project successfully and migrated packages/settings. Keep `Packages/manifest.json`, `packages-lock.json`, and migrated `ProjectSettings` together.
- Updated **DOTween core from 1.2.632 to 1.3.030** from the publisher's distribution, retaining existing asset GUIDs and saved settings. Publisher module setup was applied. No Pro components were found in the checkout; do not assume the paid Pro package is installed.
- `PanelNavigation.cs` now uses canvas-local pointer coordinates and viewport-relative panel positions. It preserves the original graph and transition settings, cancels competing tweens, and handles resizing or interrupted drags.
- The actual scene has a **zero fractional swipe threshold** after the EventSystem drag threshold. Do not replace it with the script field's default value of 25 merely because that default looks different.
- New `LandscapeLayout.cs` creates a clipped safe-area viewport, scales the original 2340 x 1080 design to fit, stretches background layers, and anchors portraits/health displays to safe bottom corners.
- Fixed selected abilities being cleared every frame by `HeroKit`, synchronized the ability cycling index in `AbilityButton`, and reset stale selection when picking a hero.
- `HeroAbilityDetails` manages video subscriptions and playback by selection/lifecycle, builds proper clip URLs, and tolerates missing clips. Main scene automatic video playback is disabled and its obsolete machine-specific URL removed.
- Unity migration recorded minimum OS settings of **iOS 15** and **Android API 26**. These were not verified with mobile builds.
- Added editor checks, render helpers, README, and technical documentation. No player builds, archives, IPAs, or TestFlight uploads have been made.

See [REVIVAL_STATUS.md](REVIVAL_STATUS.md) for implementation details and DOTween provenance, and [REVIVAL_AUDIT.md](REVIVAL_AUDIT.md) for the original audit/data dependencies.

## Evidence and remaining verification

Windows Unity 6000.6.0f1 results:

- **11 editor checks passed:** panel centering at multiple sizes/scales, drag cancellation, ability selection/index, swipe routes, resize during drag, blocked-edge return, video callback lifecycle, and real-scene routes.
- **Actual Play Mode passed:** DOTween version 1.3.030, rapid transition cancellation, ability selection across frames, ability cycling, swipe routing/settling, and health displays inside the safe-area hierarchy.
- **Six native Unity previews rendered:** hero selection and Ana's kit at 2340 x 1080, tablet 2048 x 1536, and 2400 x 1080 with simulated safe-area insets. Tablet and notched-phone kit images were visually inspected.
- Git diff whitespace check passed at the end of the migration pass.

The Play Mode log also had an **unresolved UnityEditor.Search.SearchDatabase indexing exception** during domain reload. The app checks completed successfully; do not call the overall log completely clean. Recheck on the Mac before attributing it to application code.

No iOS compilation, signing, device playback, or physical touch testing has occurred. Dela still needs to judge the swipe feel on a device. Check video decoding, notches/home indicator in both landscape orientations, tablets, background/resume behavior, and text usability on smaller phones.

### Reproduce checks on the Mac

Use the installed Unity 6000.6.0f1 executable, usually:

```sh
UNITY="/Applications/Unity/Hub/Editor/6000.6.0f1/Unity.app/Contents/MacOS/Unity"
PROJECT="/absolute/path/to/Overwatch_Sensei"
mkdir -p "$PROJECT/Logs"
"$UNITY" -batchmode -projectPath "$PROJECT" -executeMethod RevivalChecks.Run -logFile "$PROJECT/Logs/revival-checks-mac.log"
"$UNITY" -batchmode -projectPath "$PROJECT" -executeMethod RevivalPlayChecks.Run -logFile "$PROJECT/Logs/revival-play-mac.log"
"$UNITY" -batchmode -projectPath "$PROJECT" -executeMethod RevivalPreviews.Run -logFile "$PROJECT/Logs/revival-previews-mac.log"
```

Resolve the actual executable/project paths first. Run these sequentially with the project closed in other Unity instances. **Do not add `-quit`**: helpers exit when finished. Keep graphics enabled for Play Mode/previews; do not use `-nographics` for those.

Outputs: `Logs/revival-checks.txt`, `Logs/revival-play-checks.txt`, and `Logs/Previews/*.png`. The preview helper also applies landscape/module settings. Editor simulations unpack prefab instances only in memory because editor prefab restrictions otherwise prevent the runtime reparenting being simulated. They do not save those scene changes. Tween cancellation is tested in actual Play Mode because the older DOTween library intentionally skipped per-tween cancellation outside Play Mode.

## iOS and TestFlight: starting state

The last environment was **Windows**, despite earlier conversation referring to a MacBook. Only Windows standalone Unity support was installed. The Xcode MCP tool failed with `spawn xcrun ENOENT`; it was not connected to a usable Mac toolchain.

Project settings observed September 30:

| Setting | Current value |
| --- | --- |
| iOS bundle identifier | `com.test.sensei` |
| App version | `0.1` |
| iOS build number | `0` |
| Apple developer team ID | Empty |
| Automatic signing | Disabled |
| Manual provisioning profile | Empty |
| iOS minimum version | `15.0` |
| Enabled build scene | `Assets/Sensei/Scenes/Main.unity` |

`com.test.sensei` is the checked-in identifier, **not a verified registered App Store Connect identity**. Do not choose a replacement or create an unrelated app record blindly.

### Next steps on the Mac

1. Verify the transferred source and local changes. Install/locate Unity 6000.6.0f1 with **iOS Build Support**, and a supported Xcode/SDK. Check Apple's current upload requirements rather than relying on a remembered Xcode version.
2. Verify Unity import and rerun the relevant checks. Resolve iOS-specific compile/package problems while preserving navigation and DOTween.
3. Check the user's existing Xcode signing account and App Store Connect app. **Apple Developer membership status, signing team, account access, registered bundle ID, and any existing app/build numbers are unknown.** Dela has not yet answered whether the membership is active. Use secure local sign-in/keychain handling; do not request passwords or private keys in chat or commit them.
4. Confirm/reuse the correct app identity and choose an unused build number based on App Store Connect. Configure device signing, export an iOS Xcode project, and create a Release archive for physical iOS devices.
5. Validate and upload the signed archive to App Store Connect/TestFlight using available Apple tooling. Wait for processing and handle actual reported issues. Answer export-compliance and beta metadata questions from verified app behavior/user information rather than guessing.
6. Confirm the processed build is available for the intended testing audience. Start with Dela's own/internal testing where account access supports it; clarify the group if it is not evident. External beta review and inviting other people are separate actions if needed.
7. Report the real outcome: version/build number and processing/testing status, or the exact remaining blocker. Never equate an Xcode export or successful upload with a processed, installable TestFlight build.

Useful official references:

- [Unity iOS build process](https://docs.unity.com/en-us/engine/6000.5/manual/platform-specific/iphone/ios-building-and-delivering/build-process)
- [Apple: Upload builds](https://developer.apple.com/help/app-store-connect/manage-builds/upload-builds)
- [Apple: TestFlight overview](https://developer.apple.com/help/app-store-connect/test-a-beta-version/testflight-overview/)

## Content refresh remains outstanding

The app still uses the **legacy 32-hero dataset**. New heroes, current stats/abilities, and matchup advice have not been updated. The immediate TestFlight request is for testing the revival; do not describe its gameplay data as current. A later content pass needs stable hero IDs, roster-driven selection/cycling, dated public sources, and reviewed matchup advice tied to game mode and patch.

The Mac assistant should continue from this state rather than redo the entire audit or replace the swipe system.
