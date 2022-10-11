using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mute : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public Sprite oldSprite;
    private bool isOriginal = true;
    // Start is called before the first frame update
    void Start()
    {
        oldSprite = original.sprite;
    }
    public void NewImage()
    {
        if (isOriginal == true)
        {
            original.sprite = newSprite;
            AudioListener.volume = 0;
            isOriginal = false;
            Debug.Log("sounds muted");
        }
        else
        {
            original.sprite = oldSprite;
            AudioListener.volume = 1;
            isOriginal = true;
            Debug.Log("sounds unmuted");
        }

    }
}
