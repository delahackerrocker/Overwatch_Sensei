using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class HeroAbilityDetails : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI buttonName;
    public TextMeshProUGUI abilityDetail;
    public Image icon;

    public TextMeshProUGUI damage;
    public TextMeshProUGUI healing;
    public TextMeshProUGUI range;

    public VideoPlayer videoPlayer;

    protected string path = "file://E:/Developer/Overwatch_App/GIT/Overwatch_Sensei/Assets/Sensei/Resources/Heroes/Videos/";

    private void Update()
    {
        if ((Main.Instance.selectedHero != HERO_ID.None) && (Main.Instance.selectedAbility != null))
        {
            title.text = Main.Instance.selectedHero + ": "+ Main.Instance.selectedAbility.abilityName;
            buttonName.text = ""+Main.Instance.selectedAbility.controllerButton;
            abilityDetail.text = "" + Main.Instance.selectedAbility.abilityDetail;

            this.icon.sprite = Resources.Load<Sprite>(Main.Instance.selectedAbility.abilityIcon);

            if (Main.Instance.selectedAbility.damage == 0)
            {
                damage.text = "";
            } else
            {
                damage.text = "Damage: " + Main.Instance.selectedAbility.damage;
            }

            if (Main.Instance.selectedAbility.healing == 0)
            {
                healing.text = "";
            }
            else
            {
                healing.text = "Healing: " + Main.Instance.selectedAbility.healing;
            }

            if (Main.Instance.selectedAbility.range == 0)
            {
                range.text = "";
            }
            else
            {
                range.text = "Range: " + Main.Instance.selectedAbility.range;
            }

            videoPlayer.Stop();

            videoPlayer.prepareCompleted += VideoPlayer_PrepareCompleted;

            //We want to play from url
            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = path + Main.Instance.selectedAbility.abilityVideo + ".mp4";

            //Debug.Log("Trying to load video: "+ path + Main.Instance.selectedAbility.abilityVideo + ".mp4");
            //Debug.Log("path: " + path);
            //Debug.Log("dataset: "+Main.Instance.selectedAbility.abilityVideo + ".mp4");

            videoPlayer.Prepare();
        }
    }

    private void VideoPlayer_PrepareCompleted(VideoPlayer source)
    {
        videoPlayer.Play();
    }
}