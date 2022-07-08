using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsS : MonoBehaviour
{

    static bool SahnedeMuzikVar = false;
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
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
