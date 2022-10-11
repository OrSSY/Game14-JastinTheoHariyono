using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFullscreen : MonoBehaviour
{
    public void setFullscreenMode(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        if (isFullscreen)
        {
            Debug.Log("Screen changed to fullscreen");
        }
        else
        {
            Debug.Log("Screen changed to windowed");
        }
    }
}
