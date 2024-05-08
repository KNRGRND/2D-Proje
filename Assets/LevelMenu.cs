using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public string mainMenuname = "girisEkran";
    public string level1name = "level1";
    public string level2name = "level2";

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuname);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(level1name);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(level2name);
    }
}

