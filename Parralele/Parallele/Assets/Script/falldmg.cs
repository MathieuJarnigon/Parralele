using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public float minHeightForDamage = 10f;
    public life playerLife;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerLife.lifeCount--;
            playerLife.lifeUI[playerLife.lifeCount].SetActive(false);
        }
    }
}


