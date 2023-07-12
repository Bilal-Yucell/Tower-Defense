using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    public string menuSceneName = "MainMenu";

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    public void Continue()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if (true)
        {
            sceneFader.FadeTo(nextLevel);
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }
}
