using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool isPaused = false;
    public life playerLife;
    private string key = "PlayerPosition";
    public GameObject LifeUI;
    public GameManager GameManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            PauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            isPaused = true;
            Time.timeScale = 0;
            LifeUI.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true) { 
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
            isPaused = false;
            PauseMenu.SetActive(false);
            LifeUI.SetActive(true);
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
        PauseMenu.SetActive(false);
        LifeUI.SetActive(true);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("level", GameManager.level);
        PlayerPrefs.SetFloat(key + "X", transform.position.x);
        PlayerPrefs.SetFloat(key + "Y", transform.position.y);
        PlayerPrefs.SetFloat(key + "Z", transform.position.z);
        PlayerPrefs.SetInt("life", playerLife.lifeCount);
        PlayerPrefs.Save();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
