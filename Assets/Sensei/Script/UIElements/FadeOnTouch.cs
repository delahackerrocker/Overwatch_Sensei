using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FadeOnTouch : MonoBehaviour
{
    protected float fadeTime = 0.65f;
    public Image image;

    public void DoIt()
    {
        Tween fade = image.DOColor(HeroColors.Instance.alphaBlack, fadeTime);
        Invoke("ThenDisable", fadeTime);
    }

    public void ThenDisable()
    {
        this.gameObject.SetActive(false);
    }
}
