using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ButtonControl : MonoBehaviour
{
    SoundsS soundsS;



    private void Awake()
    {
        soundsS = GameObject.FindObjectOfType<SoundsS>();
    }

    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
        soundsS.ClickSound();
    }
    public void QuitButton()
    {
        soundsS.ClickSound();
        Application.Quit();
    }



}
