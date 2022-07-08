using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{



    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    public Button PauseButton;
    public Button OptionsBackButton;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        PauseMenu.gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
    }

    public void ResumeButtonClick()
    {
        PauseMenu.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(true);
        Time.timeScale = 1;
    }
    public void OptionsButtonClick()
    {
        PauseMenu.gameObject.SetActive(false);
        OptionsMenu.gameObject.SetActive(true);
    }
    public void OptionsBackButtonClick()
    {
        OptionsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }
    public void BacktoMenuButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void SetGraphics(int level)
    {
        QualitySettings.SetQualityLevel(level);
    }


}
