using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public int playerHealth;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float xInput,yInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello Outsider");
    }

    void UseVector2()
   {
        Vector2 position = new Vector2(3.0f,2.0f);
   }

   void UseStaticProperties()
   {
        Vector2 moveLeft = Vector2.left;
        Vector2 moveRight = Vector2.right;
        Vector2 moveUp = Vector2.up;
   }

    // Update is called once per frame
    void Update()

    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        transform.Translate(xInput*moveSpeed, yInput*moveSpeed,0);
    }

    void Awake()
    {
        playerHealth = 100;
    }

    void FixedUpdate()
    {
        //Health Bar
         if (playerHealth <= 20)
        {
            Debug.Log("Death is near");
        }
        else
        {
            Debug.Log("Almost past the forest");
        }
        //Physics
    }
    
 }



