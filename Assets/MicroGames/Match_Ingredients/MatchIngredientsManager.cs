using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchIngredientsManager : MonoBehaviour
{
    private int correctAnswer;

    public Sprite[] mySprites;
    //I will likely need: a public array of sprites

    public float success =0f;
    //keeping track of number of successful answers given

    private bool WinGame = false;
    private bool TimerEnded = false;
  

    void OnEnable()
    {
        Shared_EventsManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"
    }

    void OnDisable()
    {
        Shared_EventsManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"
    }


    void Start()
    {
        correctAnswer = Random.Range(0, 5);
        // Look into how to change a ui image sprite in code

        this.GetComponent<Image>().sprite = mySprites[correctAnswer];
        //the image that is displayed at the top is the correct answer that needs to be selected below

    }

    public void PlayerAnswer(int answerButtonID)
    {

        if(answerButtonID == correctAnswer)
        {
            success++;
            //if the button pressed by the character is equal to the correct answer, increase the number of successful answers
            
            if(success >= 5)
            {
                WinCondition();
                //if there are 5 or more successful answers, follow through with the win condition
            }
            else
            {
                Start();
                //if there are less than 5 successful answers, restart the correct answer
            }
            
        }
    }

    void WinCondition()
    {
        Shared_EventsManager.GameHasBeenWon();
        WinGame = true;
        //if the win condition is met above, toggle win game to true and display win game screen
    }


    void TimerLength()
    {
        TimerEnded = true;
        EndGame();
        //if the time had ended, follow through with the end game scene
    }

    void EndGame()
    {
        if (WinGame == true && TimerEnded == true)
        {
            Shared_EventsManager.GameHasBeenWon();
            //if both time and win game conditions are toggled to true, the game has been won and the player will move to the win screen
        }
        else
        {
            Shared_EventsManager.GameHasBeenLost();
            //if the time condition is toggled to true and the win game condition is not, the player has lost and follow through to lose screen
        }
    }
    // if i want a new question, i only need to run start again, if i want to count successful answers i will need a variable that is not set in start


}
