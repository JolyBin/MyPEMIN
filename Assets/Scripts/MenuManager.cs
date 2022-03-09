using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }

    public void SetTest(bool isTest)
    {
        TestManager.IsActiveMenu = isTest;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
