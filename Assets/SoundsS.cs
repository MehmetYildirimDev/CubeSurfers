using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsS : MonoBehaviour
{

    static bool SahnedeMuzikVar = false;
    public AudioClip[] audioClips;
    void Start()
    {
        if (!SahnedeMuzikVar)
        {
            SahnedeMuzikVar = true;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //sahneler arasi geciste bu objeyi yok etme diyoruz
    }
}
