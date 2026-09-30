using System;
using System.IO;
using System.Reflection;
using DG.Tweening;
using TMPro;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Editor-only renders for layout review. Does not create a player build.
public static class RevivalPreviews
{
    public static void Run()
    {
        RevivalChecks.ConfigureLandscape();
        Directory.CreateDirectory("Logs/Previews");
        Render(2340, 1080, new Rect(0, 0, 2340, 1080), "phone");
        Render(2048, 1536, new Rect(0, 0, 2048, 1536), "tablet");
        Render(2400, 1080, new Rect(90, 24, 2220, 1056), "notched-phone");
        if (Application.isBatchMode) EditorApplication.Exit(0);
    }

    private static void Call(object target, string name)
    {
        target.GetType().GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(target, null);
    }

    private static void Render(int width, int height, Rect safe, string name)
    {
        DOTween.KillAll();
        RevivalChecks.OpenSceneForSimulation();
        var nav = UnityEngine.Object.FindAnyObjectByType<PanelNavigation>();
        var main = UnityEngine.Object.FindAnyObjectByType<Main>();
        foreach (var type in new[] { typeof(Main), typeof(PanelNavigation), typeof(DebugOverlay), typeof(HeroColors), typeof(HeroSummaries), typeof(HeroMatchups), typeof(HeroCounterPicks) })
            Call(UnityEngine.Object.FindAnyObjectByType(type), "Awake");
        Call(main, "Start");
        foreach (var button in UnityEngine.Object.FindObjectsByType<PickHeroButton>()) Call(button, "Start");
        foreach (var type in new[] { typeof(HomeBG), typeof(LeftBG), typeof(RightBG), typeof(HeroLeft), typeof(HeroRight) })
            Call(UnityEngine.Object.FindAnyObjectByType(type), "Start");
        var canvas = nav.GetComponentInParent<Canvas>();
        var camera = new GameObject("PreviewCamera").AddComponent<Camera>();
        camera.orthographic = true;
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = new Color(0.08f, 0.08f, 0.1f);
        var texture = new RenderTexture(width, height, 24);
        camera.targetTexture = texture;
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = camera;
        canvas.planeDistance = 10;
        Call(nav, "Start");
        var layout = canvas.GetComponent<LandscapeLayout>();
        typeof(LandscapeLayout).GetMethod("ApplyViewport", BindingFlags.Instance | BindingFlags.NonPublic)
            .Invoke(layout, new object[] { safe, new Vector2Int(width, height) });
        Canvas.ForceUpdateCanvases();
        nav.RefreshLayout();
        var backdrop = canvas.transform.Find("Background") as RectTransform;
        if (backdrop != null && Vector2.Distance(backdrop.rect.size, ((RectTransform)canvas.transform).rect.size) > 1)
            throw new Exception(name + ": fixed-size background leaves uncovered screen space.");
        foreach (var health in canvas.GetComponentsInChildren<HealthBar>(true))
            if (!health.transform.IsChildOf(nav.transform.parent)) throw new Exception(name + ": health information is outside the safe-area hierarchy: " + AnimationUtility.CalculateTransformPath(health.transform, canvas.transform));
        nav.transform.Find("StartSplash").gameObject.SetActive(false);
        var debug = UnityEngine.Object.FindAnyObjectByType<DebugOverlay>();
        if (debug != null) debug.gameObject.SetActive(false);
        nav.GOTO_PickHero();
        DOTween.CompleteAll();
        Capture(camera, texture, name + "-heroes");
        nav.PickHero.GetComponent<PickHero>().Picked(HERO_ID.Ana);
        // This DLL intentionally skips Tween.Kill outside Play Mode. Renders need
        // only final states; actual cancellation is covered by RevivalPlayChecks.
        DOTween.KillAll();
        nav.GOTO_HeroKit();
        Call(nav.HeroKit.GetComponent<HeroKit>(), "Update");
        var transitions = DOTween.TweensByTarget(nav.transform);
        foreach (var transition in transitions) transition.Complete();
        Capture(camera, texture, name + "-kit");
        // Layout assertion uses native RectTransforms after the real safe-area layout runs.
        var viewport = (RectTransform)nav.transform.parent;
        if (viewport.rect.width < 2339 || viewport.rect.height < 1079)
            throw new Exception(name + ": original content no longer fits the safe viewport.");
        if (Vector3.Distance(nav.HeroKit.transform.position, viewport.position) > 1)
            throw new Exception(name + ": selected panel is not centered. nav=" + ((RectTransform)nav.transform).anchoredPosition + " kit=" + nav.HeroKit.transform.position + " viewport=" + viewport.position);
        camera.targetTexture = null;
        UnityEngine.Object.DestroyImmediate(texture);
        Debug.Log("PASS rendered " + name + " safe-area layout");
    }

    private static void Capture(Camera camera, RenderTexture texture, string name)
    {
        foreach (var type in new[] { typeof(HomeBG), typeof(LeftBG), typeof(RightBG), typeof(HeroLeft), typeof(HeroRight) })
            Call(UnityEngine.Object.FindAnyObjectByType(type), "Update");
        DOTween.CompleteAll();
        foreach (var text in UnityEngine.Object.FindObjectsByType<TMP_Text>()) text.ForceMeshUpdate();
        Canvas.ForceUpdateCanvases();
        camera.Render();
        var previous = RenderTexture.active;
        RenderTexture.active = texture;
        var image = new Texture2D(texture.width, texture.height, TextureFormat.RGB24, false);
        image.ReadPixels(new Rect(0, 0, texture.width, texture.height), 0, 0);
        image.Apply();
        File.WriteAllBytes("Logs/Previews/" + name + ".png", image.EncodeToPNG());
        RenderTexture.active = previous;
        UnityEngine.Object.DestroyImmediate(image);
    }
}
