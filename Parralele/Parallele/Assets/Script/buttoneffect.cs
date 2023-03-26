using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoneffect : MonoBehaviour
{
    public GameObject gameOverUI;
    public life playerLife;
    public GameObject lifePanel;
    public void exitbutton()
    {
        Application.Quit();
    }

    public void retrybutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
        lifePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        for (int i = 0; i < playerLife.lifeCount; i++)
        {
            playerLife.lifeUI[i].gameObject.SetActive(true);
        }
        playerLife.lifeCount = 2;
    }

}
