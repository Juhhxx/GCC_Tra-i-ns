using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
