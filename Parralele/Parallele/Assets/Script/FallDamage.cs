using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public life playerLife;
    public GameObject respawnPoint;
    public GameObject lifePanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && playerLife.lifeCount >= 0)
        {
            playerLife.lifeUI[playerLife.lifeCount].SetActive(false);
            playerLife.lifeCount -= 1;
            playerLife.gameObject.transform.position = respawnPoint.transform.position;
            if (playerLife.lifeCount < 0)
                lifePanel.SetActive(false);
        }
    }
}


