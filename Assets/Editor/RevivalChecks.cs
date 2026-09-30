using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using DG.Tweening;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Video;

// Run with -batchmode -executeMethod RevivalChecks.Run. No player build is made.
public static class RevivalChecks
{
    private static readonly List<string> Results = new List<string>();

    public static void Run()
    {
        Results.Clear();
        Check("Phone navigation centers the requested panel", () => NavigationCenters(2340, 1080, 1));
        Check("Tablet navigation centers the requested panel", () => NavigationCenters(2340, 1755, 0.5f));
        Check("Wide phone navigation centers the requested panel", () => NavigationCenters(2700, 1080, 2));
        Check("A button cancels an in-progress drag", ButtonCancelsDrag);
        Check("Kit refresh preserves the selected ability", KitPreservesAbility);
        Check("Selecting an ability updates the cycling index", AbilitySetsIndex);
        Check("Scaled swipes follow the original graph", ScaledSwipes);
        Check("Resize cancels a drag and keeps the selected panel", ResizeDuringDrag);
        Check("A blocked swipe eases back to its panel", BlockedSwipe);
        Check("Ability video subscribes once and releases its callback", VideoLifecycle);
        Check("Main scene preserves hero, ability, and opponent routes", MainSceneRoutes);
        Directory.CreateDirectory("Logs");
        File.WriteAllLines("Logs/revival-checks.txt", Results);
        bool failed = Results.Exists(result => result.StartsWith("FAIL"));
        Debug.Log(string.Join("\n", Results));
        if (Application.isBatchMode) EditorApplication.Exit(failed ? 1 : 0);
    }

    public static void OpenSceneForSimulation()
    {
        var scene = EditorSceneManager.OpenScene("Assets/Sensei/Scenes/Main.unity");
        // Runtime reparenting is legal in Play Mode. Unpack only this unsaved
        // editor simulation so prefab restrictions do not change the result.
        foreach (var root in scene.GetRootGameObjects())
        {
            foreach (var child in root.GetComponentsInChildren<Transform>(true))
                if (PrefabUtility.IsOutermostPrefabInstanceRoot(child.gameObject))
                    PrefabUtility.UnpackPrefabInstance(child.gameObject, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
        }
    }

    public static void ConfigureLandscape()
    {
        // Equivalent to applying the publisher's module setup, keeping saved choices.
        var modules = Type.GetType("DG.DOTweenEditor.UI.DOTweenUtilityWindowModules, DOTweenEditor", true);
        modules.GetMethod("ApplyModulesSettings", BindingFlags.Public | BindingFlags.Static).Invoke(null, null);
        PlayerSettings.defaultInterfaceOrientation = UIOrientation.AutoRotation;
        PlayerSettings.allowedAutorotateToPortrait = false;
        PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;
        PlayerSettings.allowedAutorotateToLandscapeLeft = true;
        PlayerSettings.allowedAutorotateToLandscapeRight = true;
        AssetDatabase.ForceReserializeAssets(new[]
        {
            "Assets/Plugins/Demigiant/DOTween/DOTween.dll",
            "Assets/Plugins/Demigiant/DOTween/Editor/DOTweenEditor.dll"
        }, ForceReserializeAssetsOptions.ReserializeMetadata);
        AssetDatabase.SaveAssets();
    }

    private static void Check(string name, Action test)
    {
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        try { test(); Results.Add("PASS " + name); }
        catch (Exception error) { Results.Add("FAIL " + name + ": " + error.GetBaseException().Message); }
        finally { DOTween.KillAll(); }
    }

    private static void Invoke(object target, string method)
    {
        target.GetType().GetMethod(method, BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(target, null);
    }

    private static RectTransform Rect(string name, Transform parent, Vector2 size, Vector2 position)
    {
        var rect = new GameObject(name, typeof(RectTransform)).GetComponent<RectTransform>();
        rect.SetParent(parent, false);
        rect.sizeDelta = size;
        rect.anchoredPosition = position;
        return rect;
    }

    private static PanelNavigation Navigation(float width = 2340, float height = 1080, float scale = 1)
    {
        var viewport = Rect("Viewport", null, new Vector2(width, height), new Vector2(150, 200));
        viewport.localScale = Vector3.one * scale;
        var rect = Rect("Navigation", viewport, new Vector2(width, height), Vector2.zero);
        var nav = rect.gameObject.AddComponent<PanelNavigation>();
        nav.PickHero = Rect("PickHero", rect, rect.rect.size, Vector2.zero).gameObject.AddComponent<PanelNode>();
        nav.HeroTasks = Rect("HeroTasks", rect, rect.rect.size, new Vector2(0, -height)).gameObject.AddComponent<PanelNode>();
        nav.HeroKit = Rect("HeroKit", rect, rect.rect.size, new Vector2(-width, -height)).gameObject.AddComponent<PanelNode>();
        nav.HeroAbilityDetails = Rect("HeroAbilityDetails", rect, rect.rect.size, new Vector2(-2 * width, -height)).gameObject.AddComponent<PanelNode>();
        nav.HeroTasks.left = nav.HeroKit;
        nav.HeroTasks.above = nav.PickHero;
        nav.currentlySelected = nav.HeroTasks;
        nav.percentThreshold = 0;
        Invoke(nav, "Awake");
        Invoke(nav, "Start");
        var debug = new GameObject("Debug").AddComponent<DebugOverlay>();
        debug.output = new GameObject("Output", typeof(RectTransform)).AddComponent<TextMeshProUGUI>();
        Invoke(debug, "Awake");
        return nav;
    }

    private static void NavigationCenters(float width, float height, float scale)
    {
        var nav = Navigation(width, height, scale);
        nav.GOTO_HeroTasks();
        DOTween.CompleteAll();
        var viewport = (RectTransform)nav.transform.parent;
        var center = viewport.TransformPoint(viewport.rect.center);
        if (Vector3.Distance(nav.HeroTasks.transform.position, center) > 1)
            throw new Exception("Requested panel is not centered in its viewport.");
        nav.GOTO_HeroKit();
        DOTween.CompleteAll();
        if (Vector3.Distance(nav.HeroKit.transform.position, center) > 1)
            throw new Exception("Horizontal destination is not centered in its viewport.");
    }

    private static void ButtonCancelsDrag()
    {
        var nav = Navigation();
        var events = new GameObject("Events").AddComponent<EventSystem>();
        var pointer = new PointerEventData(events) { pressPosition = new Vector2(500, 500), position = new Vector2(550, 500), pointerDrag = nav.gameObject };
        nav.OnDrag(pointer);
        nav.GOTO_PickHero();
        if (pointer.pointerDrag != null) throw new Exception("The old drag still owns the pointer.");
    }

    private static Main MainState()
    {
        var main = new GameObject("Main").AddComponent<Main>();
        Invoke(main, "Awake");
        main.selectedHero = HERO_ID.Ana;
        return main;
    }

    private static void KitPreservesAbility()
    {
        var main = MainState();
        var ability = new AbilityData();
        main.selectedAbility = ability;
        var kit = new GameObject("Kit").AddComponent<HeroKit>();
        kit.nowShowing = HERO_ID.Ana;
        Invoke(kit, "Update");
        if (main.selectedAbility != ability) throw new Exception("An unchanged kit erased the active ability.");
    }

    private static void AbilitySetsIndex()
    {
        Navigation();
        var main = MainState();
        var abilities = new[] { new AbilityData(), new AbilityData(), new AbilityData() };
        main.heroes[0] = new HeroData { abilities = abilities };
        var button = new GameObject("Ability").AddComponent<AbilityButton>();
        button.abilityData = abilities[2];
        button.Select();
        if (main.abilityIndex != 2) throw new Exception("Next ability would cycle from a stale index.");
    }

    private static PointerEventData Pointer(PanelNavigation nav, Vector2 movement)
    {
        var events = new GameObject("Events").AddComponent<EventSystem>();
        return new PointerEventData(events) { pressPosition = new Vector2(500, 500), position = new Vector2(500, 500) + movement, pointerDrag = nav.gameObject };
    }

    private static void ScaledSwipes()
    {
        var nav = Navigation(2340, 1080, 0.5f);
        var pointer = Pointer(nav, new Vector2(100, 0));
        nav.OnDrag(pointer);
        // 100 screen pixels are 200 local canvas units.
        if (Mathf.Abs(((RectTransform)nav.transform).anchoredPosition.x - 200) > 0.1f)
            throw new Exception("Drag does not follow the finger after scaling.");
        nav.OnEndDrag(pointer);
        if (nav.currentlySelected != nav.HeroKit) throw new Exception("Rightward swipe did not follow the left neighbor.");
        DOTween.CompleteAll();
        nav.GOTO_HeroTasks();
        DOTween.CompleteAll();
        pointer = Pointer(nav, new Vector2(0, -100));
        nav.OnDrag(pointer);
        nav.OnEndDrag(pointer);
        if (nav.currentlySelected != nav.PickHero) throw new Exception("Downward swipe did not return home.");
    }

    private static void ResizeDuringDrag()
    {
        var nav = Navigation();
        var pointer = Pointer(nav, new Vector2(100, 0));
        nav.OnDrag(pointer);
        ((RectTransform)nav.transform.parent).sizeDelta = new Vector2(2340, 1755);
        Invoke(nav, "Update");
        nav.OnEndDrag(pointer);
        if (nav.currentlySelected != nav.HeroTasks || pointer.pointerDrag != null)
            throw new Exception("A stale drag changed the selected panel after resizing.");
        if (Vector3.Distance(nav.HeroTasks.transform.position, nav.transform.parent.position) > 1)
            throw new Exception("Resize did not recenter the selected panel.");
    }

    private static void BlockedSwipe()
    {
        var nav = Navigation();
        var pointer = Pointer(nav, new Vector2(-100, 0));
        nav.OnDrag(pointer);
        nav.OnEndDrag(pointer);
        if (nav.currentlySelected != nav.HeroTasks) throw new Exception("Swiped through a missing neighbor.");
        if (!DOTween.IsTweening(nav.transform)) throw new Exception("Blocked swipe snapped instead of easing back.");
    }

    private static void VideoLifecycle()
    {
        var nav = Navigation();
        var main = MainState();
        main.selectedAbility = new AbilityData { abilityName = "Rifle", abilityVideo = "Ana/ability-biotic-rifle" };
        nav.GOTO_HeroAbilityDetails();
        var details = nav.HeroAbilityDetails.gameObject.AddComponent<HeroAbilityDetails>();
        details.title = new GameObject("Title", typeof(RectTransform)).AddComponent<TextMeshProUGUI>();
        details.buttonName = new GameObject("Button", typeof(RectTransform)).AddComponent<TextMeshProUGUI>();
        details.abilityDescription = new GameObject("Description", typeof(RectTransform)).AddComponent<TextMeshProUGUI>();
        details.abilityDetails = new GameObject("Details", typeof(RectTransform)).AddComponent<TextMeshProUGUI>();
        details.icon = new GameObject("Icon", typeof(RectTransform)).AddComponent<Image>();
        details.videoPlayer = details.gameObject.AddComponent<VideoPlayer>();
        Invoke(details, "OnEnable");
        Invoke(details, "Update");
        Invoke(details, "Update");
        var callback = typeof(VideoPlayer).GetField("prepareCompleted", BindingFlags.Instance | BindingFlags.NonPublic);
        var handlers = callback.GetValue(details.videoPlayer) as Delegate;
        if (handlers == null || handlers.GetInvocationList().Length != 1)
            throw new Exception("Video callbacks accumulate while the selected ability is unchanged.");
        if (!details.videoPlayer.url.StartsWith("file:///")) throw new Exception("Local video URL is not an absolute file URI.");
        Invoke(details, "OnDisable");
        if (callback.GetValue(details.videoPlayer) != null) throw new Exception("Video callback retained after disabling details.");
    }

    private static void MainSceneRoutes()
    {
        OpenSceneForSimulation();
        var main = UnityEngine.Object.FindAnyObjectByType<Main>();
        var nav = UnityEngine.Object.FindAnyObjectByType<PanelNavigation>();
        foreach (var type in new[] { typeof(Main), typeof(PanelNavigation), typeof(DebugOverlay), typeof(HeroColors), typeof(HeroSummaries), typeof(HeroMatchups), typeof(HeroCounterPicks) })
            Invoke(UnityEngine.Object.FindAnyObjectByType(type), "Awake");
        Invoke(main, "Start");
        Invoke(nav, "Start");
        foreach (var button in UnityEngine.Object.FindObjectsByType<PickHeroButton>()) Invoke(button, "Start");
        nav.PickHero.GetComponent<PickHero>().Picked(HERO_ID.Ana);
        DOTween.CompleteAll();
        Invoke(nav.HeroTasks.GetComponent<HeroTasks>(), "Update");
        nav.GOTO_HeroKit();
        Invoke(nav.HeroKit.GetComponent<HeroKit>(), "Update");
        var abilityButton = nav.HeroKit.GetComponent<HeroKit>().rightTriggerBTN;
        abilityButton.Select();
        var chosen = main.selectedAbility;
        Invoke(nav.HeroKit.GetComponent<HeroKit>(), "Update");
        if (chosen == null || main.selectedAbility != chosen) throw new Exception("Ability details lost their data in the main scene.");
        nav.NextHeroAbilityDetails.GetComponent<NextHeroAbility>().GoToNext();
        if (main.selectedAbility == chosen) throw new Exception("Next ability did not cycle.");
        nav.GOTO_HeroVersusHero();
        main.counterPick = HERO_ID.Zenyatta;
        nav.HeroVersusHero_Next.GetComponent<HeroVersusHero>().GoToHero();
        if (main.counterPick != HERO_ID.Ana || nav.currentlySelected != nav.HeroVersusHero)
            throw new Exception("Opponent wraparound route changed.");
        Invoke(nav.HeroVersusHero.GetComponent<HeroVersusHero>(), "Update");
        nav.GOTO_HeroCounterPicks();
        Invoke(nav.HeroCounterPicks.GetComponent<HeroCounterPicks>(), "Update");
        nav.GOTO_PickHero();
        Invoke(nav, "Update");
        if (main.selectedHero != HERO_ID.None || main.counterPick != HERO_ID.None)
            throw new Exception("Home route failed to clear selection.");
    }
}
