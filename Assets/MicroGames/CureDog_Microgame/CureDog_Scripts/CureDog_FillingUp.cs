using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CureDog_FillingUp : MonoBehaviour
{
    private bool dogFullStatus = false; //to cap it
    private bool potionActivate = false; //for whether to pour or not
    private float intPourTime = 0.0f; //counter for holding **needs Work - Oscar**
    private int seconds;

    private bool GameTimerEnded = false;
    private bool WinGame = false;

    void OnEnable()
    {
        CureDog_EventManager.PouredPotion += PotionCount;
        CureDog_EventManager.NoPotion += PotionFreeze;
        Shared_EventsManager.EndOfMicroGame += GameTimeDuration; //from the "Shared_EventsManager"
    }
    
    void OnDisable()
    {
        CureDog_EventManager.PouredPotion -= PotionCount;
        CureDog_EventManager.NoPotion -= PotionFreeze;
        Shared_EventsManager.EndOfMicroGame -= GameTimeDuration; //from the "Shared_EventsManager"
    }
    
    void Update()
    {
        //if (the mouse button is being held down)
        //{
            //increase the number by one every second
        //}

        //else if the mouse is NOT being held down
        //{
            //stop the timer at whatever value it is at
        //}
        
        if(potionActivate == true)
        {
            TimerPouring();
        }
        else if(potionActivate == false)
        {
            TimerResetPour();
        }
    }

    void PotionCount()
    {   
        //Is the Mouse being held?
        //Should the game be running as if it is running?
        //Yes it should
        potionActivate = true;
    }

    void PotionFreeze()
    {   
        //Is the Mouse being held?
        //Should the game be running as if it is running?
        //No it shouldn't
        potionActivate = false;
    }

    void TimerPouring()
    {
        //increase value of timer
        //print value in console
        //if(the timer reaches the value of 6)
        //{
            //win the game
            //print win
        //}
        
        //seconds
        intPourTime += Time.deltaTime;
        //turn float into seconds
        seconds = (int)(intPourTime % 60);
        print(intPourTime);
                
        if(intPourTime >= 6f)
        {
            WinGame = true;
            dogFullStatus = true;
            print("win");
        }
    }

    void TimerResetPour()
    {
        //reset the value of the timer back to 0 and keep at 0 until turned on.

        //seconds
        intPourTime = Time.deltaTime;
        //turn float into seconds
        seconds = (int)(intPourTime % 60);
        print(intPourTime);
    }

    void GameTimeDuration()
    {
        //if the TimeDuration is called from the event
        //{
            //bool TimeEnded changes to true
            //run the end game function
        //}

        GameTimerEnded = true;
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

        if(WinGame == true && GameTimerEnded == true)
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