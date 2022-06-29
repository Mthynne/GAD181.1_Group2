using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogBeautyComp_Cheer : MonoBehaviour
{
    private int cheerNum = 0;
    private bool TimerEnded;
    private bool WinGame;
    
    void OnEnable()
    {
        DogBeautyComp_EventsManager.CheerTheDogOn += IncreaseCheerNum; //from the "Shared_EventsManager"
        Shared_EventsManager.EndOfMicroGame += TimeDuration; //from the "Shared_EventsManager"

    }
    void OnDisable()
    {
        Shared_EventsManager.MouseHold -= IncreaseCheerNum; //from the "Shared_EventsManager"

    }
    void Start()
    {
        TimerEnded = false;
        WinGame = false;
    }

    void IncreaseCheerNum()
    {
        cheerNum++;
        print(cheerNum);
        WinCondition();
    }
    
    void WinCondition()
    {
        //if the ingredient number is greater then or equal to 15
        //{
            //player is eligeble to win the game
        //}

        if(cheerNum >= 30)
        {
            WinGame = true;
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
            //print the word winner in the console    
        //}
        //else
        //{
            //reload the scene to try again    
        //}

        if(WinGame == true && TimerEnded == true)
        {
            print("WINNER!");
        }
        else
        {
            print("FAILED!");
            ReloadScene();
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reloads the scene again.
    }
}