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
        while (true)
        if (isOriginal == true)
        {
            original.sprite = newSprite;
            isOriginal = false;
            break;
        }
        else
        {
            original.sprite = oldSprite;
            isOriginal = true;
            break;
        }

    }
}
