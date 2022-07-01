using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Win_Condition : MonoBehaviour
{
    private bool TimerEnded;
    private bool WinGame;

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
        WinGame = true;
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
