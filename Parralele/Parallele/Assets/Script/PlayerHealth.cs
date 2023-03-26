using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public life life;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            life.lifeUI[life.lifeCount].SetActive(false);
            life.lifeCount--;
        }
    }
}

