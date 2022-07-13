using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Movement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private bool WinGame;
    private bool TimerEnded;
    private bool isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    //Update is called once per frame
    void Update()
    {
       if(transform.position.x <= -13.38f)
       {
            Destroy(this.gameObject);
       }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Heart_System.health--;
            if(Heart_System.health<=0)
            {
                Destroy(collision.gameObject);
                Debug.Log("You Lose!");
                isDead = true;
                WinGame = false;
                Shared_EventsManager.GameHasBeenLost();
            }
           
        }

    }
   
}
