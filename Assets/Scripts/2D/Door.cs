using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool keyRequired = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            if (!keyRequired || (player != null && player.IsThereKey()))
            {
                LevelTransition();
            }
            else
            {
                Debug.Log("You need to find the key to open the door!");
            }
        }
    }

    private void LevelTransition()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }
}
