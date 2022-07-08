using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsS : MonoBehaviour
{
    //Sorun Statik deðiþken
    //static bool SahnedeMuzikVar = false;
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    private static SoundsS sounds;
    private void Awake()
    {
        if (sounds==null)
        {
            sounds = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else if (this!=sounds)
        {
            Destroy(gameObject);   
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void ClickSound()
    {
        audioSource.PlayOneShot(audioClips[0]);
    }
     public void TakeCubeSound()
    {
        audioSource.PlayOneShot(audioClips[1]);
    }
     public void DropCubeSound()
    {
        audioSource.PlayOneShot(audioClips[2]);
    }

}
