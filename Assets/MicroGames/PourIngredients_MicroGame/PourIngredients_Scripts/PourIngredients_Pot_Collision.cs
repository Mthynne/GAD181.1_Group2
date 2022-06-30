using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourIngredients_Pot_Collision : MonoBehaviour
{
    private int ingredNum;
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
    
    void Start()
    {
        TimerEnded = false; //timer hasnt ended
        WinGame = false; //game hasn't won
        ingredNum = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        //if the "ingredients" touch the pot
        //{
            //increase the count of ingredients everytime an ingredient lands in the pot
            //print in the console
            //run WinCondition()    
        //}
        
        if(collision.gameObject.GetComponent<PourIngredients_Ingredient_Prefab>() != null)
        {
            ingredNum++;
            print("Added ingredient: " + ingredNum);
            WinCondition();
        }
    }


    void WinCondition()
    {
        //if the ingredient number is greater then or equal to 15
        //{
            //player is eligeble to win the game
        //}

        if(ingredNum >= 18)
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
            //change the scene to the next in order
            //print the word winner in the console    
        //}
        //else
        //{
            //print "failed" into the console
            //reload the scene to try again    
        //}

        if(WinGame == true && TimerEnded == true)
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
