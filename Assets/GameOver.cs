using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public void restartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void mainmenuButton()
    {
        SceneManager.LoadScene("OyunGiris");
    }
}
