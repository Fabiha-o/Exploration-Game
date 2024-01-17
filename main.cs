using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public int playerHealth;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Welcome");
    }

    // Update is called once per frame
    void Update()
    {
        //Game Logic
    }

    void Awake()
    {
        playerHealth = 100;
    }

    void FixedUpdate()
    {
        //Physics realted code
    }
}
