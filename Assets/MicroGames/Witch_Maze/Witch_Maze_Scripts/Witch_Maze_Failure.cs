using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Maze_Failure : MonoBehaviour
{
    private bool TimerEnded;
    private bool WinGame;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
           
            Destroy(collision.gameObject);
            Debug.Log("You Lose!");
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
