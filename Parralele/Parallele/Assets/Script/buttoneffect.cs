using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoneffect : MonoBehaviour
{
    public GameObject gameOverUI;
    public void exitbutton()
    {
        Application.Quit();
    }

    public void retrybutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
    }

}
