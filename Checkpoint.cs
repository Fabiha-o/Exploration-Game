using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private PlayerRespawn playerRespawn;

    // Start is called before the first frame update
    void Start()
    {
        playerRespawn = GameObject.Find("Player1").GetComponent<PlayerRespawn>();
    }

   private OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.name == "Player1")
        {
            playerRespawn.respawnPoint = transform.position;
        }
   }
}
