using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    private Player1 playerRespawn;
    // Start is called before the first frame update
    void Start()
    {
        playerRespawn = GameObject.Find("Player1").GetComponent<Player1>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            playerRespawn.respawnPoint = transform.position;
        }
    }
}
