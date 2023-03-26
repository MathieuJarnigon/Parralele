using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public GameObject[] lifeUI;
    public GameObject gameOverUI;
    public int lifeCount = 2;
    public int lifeMax = 2;

    void Update()
    {
        if (lifeCount < 0)
        {
            gameOverUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
    }
}
