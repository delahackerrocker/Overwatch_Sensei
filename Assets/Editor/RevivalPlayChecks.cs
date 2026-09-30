using System;
using System.IO;
using DG.Tweening;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

[InitializeOnLoad]
public static class RevivalPlayChecks
{
    private const string Key = "Sensei.RevivalPlayChecks";
    private static int _stage;
    private static float _deadline;
    private static AbilityData _ability;

    static RevivalPlayChecks()
    {
        EditorApplication.update += Tick;
        EditorApplication.playModeStateChanged += state =>
        {
            if (state == PlayModeStateChange.EnteredEditMode && SessionState.GetBool(Key + ".finished", false))
            {
                SessionState.SetBool(Key + ".finished", false);
                if (Application.isBatchMode) EditorApplication.Exit(SessionState.GetInt(Key + ".exit", 1));
            }
        };
    }

    public static void Run()
    {
        EditorSceneManager.OpenScene("Assets/Sensei/Scenes/Main.unity");
        SessionState.SetBool(Key, true);
        EditorApplication.EnterPlaymode();
    }

    private static void Tick()
    {
        if (!SessionState.GetBool(Key, false) || !EditorApplication.isPlaying || Time.frameCount < 5) return;
        try
        {
            var nav = PanelNavigation.Instance;
            var main = Main.Instance;
            if (nav == null || main == null) throw new Exception("Main scene did not initialize.");
            if (_stage == 0)
            {
                if (DOTween.Version != "1.3.030") throw new Exception("Unexpected DOTween version: " + DOTween.Version);
                foreach (var health in nav.GetComponentInParent<Canvas>().GetComponentsInChildren<HealthBar>(true))
                    if (!health.transform.IsChildOf(nav.transform.parent)) throw new Exception("Health information is outside the safe area.");
                nav.transform.Find("StartSplash").gameObject.SetActive(false);
                nav.PickHero.GetComponent<PickHero>().Picked(HERO_ID.Ana);
                nav.GOTO_HeroTasks();
                nav.GOTO_HeroKit();
                var transitions = DOTween.TweensByTarget(nav.transform);
                if (transitions == null || transitions.Count != 1) throw new Exception("Rapid navigation left multiple active transitions.");
                _deadline = Time.unscaledTime + 0.7f;
                _stage++;
            }
            else if (_stage == 1 && Time.unscaledTime >= _deadline)
            {
                if (Vector3.Distance(nav.HeroKit.transform.position, nav.transform.parent.position) > 1)
                    throw new Exception("Latest navigation destination was not reached.");
                nav.HeroKit.GetComponent<HeroKit>().rightTriggerBTN.Select();
                _ability = main.selectedAbility;
                _deadline = Time.unscaledTime + 1f;
                _stage++;
            }
            else if (_stage == 2 && Time.unscaledTime >= _deadline)
            {
                if (_ability == null || main.selectedAbility != _ability) throw new Exception("Ability selection was lost across frames.");
                nav.NextHeroAbilityDetails.GetComponent<NextHeroAbility>().GoToNext();
                if (main.selectedAbility == _ability) throw new Exception("Next ability failed to cycle.");
                nav.GOTO_HeroTasks();
                DOTween.Complete(nav.transform);
                var pointer = new PointerEventData(EventSystem.current) { pressPosition = new Vector2(500, 500), position = new Vector2(600, 500), pointerDrag = nav.gameObject };
                nav.OnBeginDrag(pointer);
                nav.OnDrag(pointer);
                nav.OnEndDrag(pointer);
                if (nav.currentlySelected != nav.HeroKit) throw new Exception("Swipe no longer follows the original graph.");
                _deadline = Time.unscaledTime + 0.7f;
                _stage++;
            }
            else if (_stage == 3 && Time.unscaledTime >= _deadline)
            {
                if (Vector3.Distance(nav.HeroKit.transform.position, nav.transform.parent.position) > 1)
                    throw new Exception("Swipe failed to settle on its selected panel.");
                Finish("PASS Play Mode: rapid transitions, cross-frame ability selection, ability cycling, swipe route and settling.", 0);
            }
        }
        catch (Exception error) { Finish("FAIL Play Mode: " + error.GetBaseException().Message, 1); }
    }

    private static void Finish(string result, int code)
    {
        Directory.CreateDirectory("Logs");
        File.WriteAllText("Logs/revival-play-checks.txt", result);
        Debug.Log(result);
        SessionState.SetBool(Key, false);
        SessionState.SetBool(Key + ".finished", true);
        SessionState.SetInt(Key + ".exit", code);
        EditorApplication.ExitPlaymode();
    }
}
