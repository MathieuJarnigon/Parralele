using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public GameObject[] lifeUI;
    public GameObject gameOverUI;
    public int lifeCount = 3;
    public int lifeMax = 3;

    void Update()
    {
        if (lifeCount <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.M)) 
        {
            lifeCount--;
        }
    }
}
