using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

    public Image MainPanel;
    public Image SettingsPanel;
    
    public void StartButton()
    {

    }
    public void SettingsButton()
    {
        MainPanel.gameObject.SetActive(false);
        SettingsPanel.gameObject.SetActive(true);
    }
    public void QuitButton()
    {
        
    }

}
