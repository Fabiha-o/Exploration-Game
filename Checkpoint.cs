using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private Player1 playerRespawn;

    // Start is called before the first frame update
    void Start()
    { 
        playerRespawn = GameObject.Find("Player1").GetComponent<Player1>();
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.name == "Player1")
        {
            playerRespawn.respawnPoint = transform.position;
        }
   }
}
