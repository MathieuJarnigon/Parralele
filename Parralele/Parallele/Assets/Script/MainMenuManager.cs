using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject LevelUI;
    public GameObject MainMenu;

    public void LevelNew(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void LevelSelector()
    {
        LevelUI.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        LevelUI.SetActive(false);
        MainMenu.SetActive(true);
    }
}
