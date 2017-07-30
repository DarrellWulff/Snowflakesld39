using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fading : MonoBehaviour
{

    public static Fading Instance { set; get; }

    public Image fadeImage;
    public bool isInTransition;
    private float transition;
    private bool isShowing;
    private float duration;

    private void Awake()
    {
        Instance = this;


    }

    public void Fade(bool showing, float duration)
    {
        fadeImage.enabled = true;
        isShowing = showing;
        isInTransition = true;
        this.duration = duration;
        transition = (isShowing) ? 0 : 1;

    }

    private void Update()
    {
        if (!isInTransition) { fadeImage.enabled = false; return; }

        transition += (isShowing) ? Time.deltaTime * (1 / duration) : -Time.deltaTime * (1 / duration);

        fadeImage.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);

        if (transition > 1 || transition < 0) { isInTransition = false; }
    }

}
