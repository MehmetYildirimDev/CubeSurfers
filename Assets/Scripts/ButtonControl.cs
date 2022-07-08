using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

    public Image MainPanel;
    public Image SettingsPanel;
    public SoundsS soundsS;
    
    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
        soundsS.ClickSound();
    }
    public void SettingsButton()
    {
        MainPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
        soundsS.ClickSound();
    }
    public void QuitButton()
    {
        soundsS.ClickSound();
        Application.Quit();
    }
    public void SettingsBackButton()
    {
        MainPanel.gameObject.SetActive(true);
        SettingsPanel.gameObject.SetActive(false);
        soundsS.ClickSound();
    }

}
