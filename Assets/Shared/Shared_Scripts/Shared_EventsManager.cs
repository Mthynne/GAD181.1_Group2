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
   
    //Event to do Win function
    public delegate void WinningEvent();
    public static event WinningEvent CompleteGame;

    public static void GameHasBeenWon()
    {
        CompleteGame();
    }

    //Event to do Lose function
    public delegate void LosingEvent();
    public static event LosingEvent LostTheGame;

    public static void GameHasBeenLost()
    {
        LostTheGame();
    }
}
