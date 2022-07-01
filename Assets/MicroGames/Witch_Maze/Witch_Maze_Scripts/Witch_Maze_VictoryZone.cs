using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Maze_VictoryZone : MonoBehaviour
{
    private bool TimerEnded;
    private bool WinGame;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
           
            Destroy(collision.gameObject);
            Debug.Log("Victory!");
        }

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
        //if the player is eligable to win the game and the timer has ended
        //{
        //change the scene to the next in order
        //print the word winner in the console    
        //}
        //else
        //{
        //print "failed" into the console
        //reload the scene to try again    
        //}

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

    
