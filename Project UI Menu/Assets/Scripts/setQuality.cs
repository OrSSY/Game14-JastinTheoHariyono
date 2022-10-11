using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setQuality : MonoBehaviour
{
    public void setQ(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        if (qualityIndex == 0)
        {
            Debug.Log("Quality changed to Low");
        }
        else if(qualityIndex == 1)
        {
            Debug.Log("Quality changed to Medium");
        }
        else if(qualityIndex == 2)
        {
            Debug.Log("Quality changed to High");
        }
    }
}
