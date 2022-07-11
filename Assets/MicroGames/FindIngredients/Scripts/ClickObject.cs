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
        print("Timer done");
        EndGame();
    }

    void EndGame()
    {
        if(WinGame == true && TimerDone == true)
        {
            print("Success");
            Shared_EventsManager.GameHasBeenWon();
        }
        else
        {
            print("Loser");
            Shared_EventsManager.GameHasBeenLost();
        }
    }

}
