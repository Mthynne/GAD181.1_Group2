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
    public GameObject Witch;
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

            Destroy(collision.gameObject);
            Debug.Log("You Lose!");
            isDead = true;
            WinGame = false;
        }

    }
    void OnEnable() //enable called event
    {
        Shared_EventsManager.EndOfMicroGame += TimeDuration; //from the "Shared_EventsManager"
    }
    void OnDisable() //disable called event
    {
        Shared_EventsManager.EndOfMicroGame -= TimeDuration; //from the "Shared_EventsManager"
    }
    void TimeDuration()
    {
        //if the TimeDuration is called from the event
        //{
        //bool TimeEnded changes to true
        //run the end game function
        //}

        TimerEnded = true;
        WinGame = false;
        EndGame();
    }
    void EndGame()
    {


        if (WinGame == true && TimerEnded == true)
        {
            print("WINNER!");
            Shared_EventsManager.GameHasBeenWon();
        }
        else
        {
            print("FAILED!");
            Shared_EventsManager.GameHasBeenLost();
        }
    }

}
