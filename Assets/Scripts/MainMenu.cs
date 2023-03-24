using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayBallGame()
    {
        SceneManager.LoadScene("BallScene");
    }

    public void PlaySquareGame()
    {
        SceneManager.LoadScene("SquareScene");
    }


    public void PlayCylinderGame()
    {
        SceneManager.LoadScene("CylinderScene");
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
