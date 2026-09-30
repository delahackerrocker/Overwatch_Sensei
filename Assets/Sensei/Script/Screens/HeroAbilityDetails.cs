using System;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class HeroAbilityDetails : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI buttonName;
    public TextMeshProUGUI abilityDescription;
    public Image icon;
    public TextMeshProUGUI abilityDetails;
    public VideoPlayer videoPlayer;

    private AbilityData _shownAbility;
    private HERO_ID _shownHero = HERO_ID.None;
    private VideoPlayer _subscribedPlayer;

    private void OnEnable() => Subscribe();

    private void Subscribe()
    {
        if (_subscribedPlayer == videoPlayer) return;
        Unsubscribe();
        _subscribedPlayer = videoPlayer;
        if (_subscribedPlayer == null) return;
        _subscribedPlayer.playOnAwake = false;
        _subscribedPlayer.prepareCompleted += VideoPlayer_PrepareCompleted;
        _subscribedPlayer.errorReceived += VideoPlayer_ErrorReceived;
    }

    private bool IsSelected()
    {
        return Main.Instance != null && Main.Instance.selectedHero != HERO_ID.None &&
            Main.Instance.selectedAbility != null && PanelNavigation.Instance != null &&
            PanelNavigation.Instance.currentlySelected == PanelNavigation.Instance.HeroAbilityDetails;
    }

    private void Update()
    {
        Subscribe();
        if (!IsSelected())
        {
            if (_shownAbility != null && videoPlayer != null) videoPlayer.Stop();
            _shownAbility = null;
            return;
        }
        var main = Main.Instance;
        if (_shownAbility == main.selectedAbility && _shownHero == main.selectedHero) return;
        _shownAbility = main.selectedAbility;
        _shownHero = main.selectedHero;

        title.text = _shownHero + ": " + _shownAbility.abilityName;
        buttonName.text = _shownAbility.controllerButton.ToString();
        abilityDescription.text = _shownAbility.abilityDescription;
        icon.sprite = string.IsNullOrEmpty(_shownAbility.abilityIcon) ? null : Resources.Load<Sprite>(_shownAbility.abilityIcon);
        abilityDetails.text = _shownAbility.abilityDetails == null ? "" : string.Join("\n", _shownAbility.abilityDetails);
        if (videoPlayer == null) return;
        videoPlayer.Stop();
        if (string.IsNullOrWhiteSpace(_shownAbility.abilityVideo)) return;

        videoPlayer.source = VideoSource.Url;
        string basePath = Application.streamingAssetsPath;
        string relative = _shownAbility.abilityVideo + ".mp4";
        // Android StreamingAssets already has a jar:file URL. Desktop/iOS use filesystem paths.
        if (basePath.Contains("://"))
            videoPlayer.url = basePath.TrimEnd('/') + "/" + string.Join("/", relative.Split('/').Select(Uri.EscapeDataString));
        else
        {
            string filePath = Path.Combine(basePath, relative);
            videoPlayer.url = new Uri(filePath).AbsoluteUri;
            if (!File.Exists(filePath)) return; // Text remains available when an old clip is missing.
        }
        videoPlayer.Prepare();
    }

    private void VideoPlayer_PrepareCompleted(VideoPlayer source)
    {
        if (IsSelected() && _shownAbility == Main.Instance.selectedAbility) source.Play();
    }

    private void VideoPlayer_ErrorReceived(VideoPlayer source, string message)
    {
        Debug.LogWarning("Ability video unavailable: " + message, this);
    }

    private void Unsubscribe()
    {
        if (_subscribedPlayer == null) return;
        _subscribedPlayer.prepareCompleted -= VideoPlayer_PrepareCompleted;
        _subscribedPlayer.errorReceived -= VideoPlayer_ErrorReceived;
        _subscribedPlayer = null;
    }

    private void OnDisable()
    {
        Unsubscribe();
        if (videoPlayer != null) videoPlayer.Stop();
        _shownAbility = null;
    }
}
