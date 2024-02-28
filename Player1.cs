using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public int playerHealth;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float xInput,yInput;
    public Vector2 respawnPoint;
    public bool beginingofthegame = false; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void UseVector2()
   {
        Vector2 position = new Vector2(3.0f,2.0f);
   }
   void array(){
         //Introduction Text
         if  (beginingofthegame == false){
            string[] intro = {"Oh! Hello outsider","I have been longing to meet with my family for awhile", "I actually ran away from home to become a traveler, but thankfully my sister found me and convinced me to go back", "I'm heading there right now, but it seems like the forest around my home changed a lot, can you help?"};
            for (int i = 0; i < intro.Length; i++)
            {
                Debug.Log(intro[i]);
            }
        
             }
             beginingofthegame = true; 
        
   }

   void UseStaticProperties()
   {
        Vector2 moveLeft = Vector2.left;
        Vector2 moveRight = Vector2.right;
        Vector2 moveUp = Vector2.up;
   }

   public void RespawnNow()
   {
        transform.position = respawnPoint;
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
        if (collision.gameObject.tag == "Death")
        {
            RespawnNow();
        }
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
        array();
        //Introduction Text
        string[] intro = {"Oh! Hello outsider", "I actually ran away from home to become a traveler, but thankfully my sister found me and convinced me to go back","I have been longing to meet with my family for awhile", "I'm heading there right now, but it seems like the forest around my home changed a lot, can you help?"};
        for (int i = 0; i < intro.Length; i++)
        {
            Debug.Log(intro[i]);
        }
    }
    
    

    void FixedUpdate()
    {
       /* //Health Bar
         if (playerHealth <= 20)
        {
            Debug.Log("Death is near");
        }
        else
        {
            Debug.Log("Use arrow keys to move");
        }
        //Physics
          */
    }
  
 }
