using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    private bool isSettingsActive;

    public void StartButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        if (isSettingsActive)
        {
            settings.SetActive(false);
            isSettingsActive = false;
        }
        else
        {
            settings.SetActive(true);
            isSettingsActive = true;
        }
    }
}
