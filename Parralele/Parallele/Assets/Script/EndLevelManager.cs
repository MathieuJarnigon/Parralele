using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelManager : MonoBehaviour
{
    public GameObject LifeUI;
    public GameObject EndUI;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            EndUI.SetActive(true);
            LifeUI.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
