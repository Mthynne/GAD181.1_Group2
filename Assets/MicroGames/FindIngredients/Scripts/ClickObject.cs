using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    public static string objectName;
    //name of object
    public GameObject objectNameText;
    //text at bottom of game corresponding to the object in the game screen
    private bool TimerDone;
    public bool WinGame;

    void Start()
    {
        TimerDone = false;
        WinGame = false;
    }

    void OnEnable()
    {
        Shared_EventsManager.EndOfMicroGame += TimeDuration; //from the "Shared_EventsManager"
        Shared_EventsManager.CompleteGame += DidIWin;
    }

    void OnDisable()
    {
        Shared_EventsManager.EndOfMicroGame -= TimeDuration; //from the "Shared_EventsManager"
    }

    void DidIWin()
    {
        WinGame = true;
    }


    void TimeDuration()
    {
        TimerDone = true;
        EndGame();
    }

    void EndGame()
    {
        if(WinGame == true && TimerDone == true)
        {
            Shared_EventsManager.GameHasBeenWon();
            //if the win game bool is triggered to true and timerdone is triggered to true, the code follows through to the win game script
        }
        else
        {
            Shared_EventsManager.GameHasBeenLost();
            //if either of these bools have not been triggered to true then the game has been lost
        }
    }

}
