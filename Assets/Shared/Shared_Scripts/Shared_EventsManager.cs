using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_EventsManager : MonoBehaviour
{
    //Event to do Hold Mouse Left
    public delegate void HoldingMouse();
    public static event HoldingMouse MouseHold;

    public static void HeldMouse()
    {
        MouseHold();
    }

    //Event to do Release Mouse Left
    public delegate void ReleasedMouse();
    public static event ReleasedMouse MouseLetGo;

    public static void NoMouseInput()
    {
        MouseLetGo();
    }
    
    //Event to do end of timer function
    public delegate void EndOfTimer();
    public static event EndOfTimer EndOfMicroGame;

    public static void TimerDone()
    {
        EndOfMicroGame();
    }

    //Event to do the change scene function in order
    public delegate void CompleteGame();
    public static event CompleteGame MicroGameSuccess;

    public static void GameWasCompleted()
    {
        MicroGameSuccess();
    }

    //Event to do the change scene back to same scene.
    public delegate void FailedGame();
    public static event FailedGame MicroGameFailed;

    public static void TheGameFailed()
    {
        MicroGameFailed();
    }

}
