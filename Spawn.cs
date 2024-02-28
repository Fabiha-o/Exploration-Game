using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Blocker;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Blocker, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
