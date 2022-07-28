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


    }

    public void PlayerAnswer(int answerButtonID)
    {
        print("You have selected the " + answerButtonID);

        if(answerButtonID == correctAnswer)
        {
            success++;
            Debug.Log(success);
            
            if(success >= 5)
            {
                Debug.Log("Win");
                WinCondition();
            }
            else
            {
                Start();
            }
            
        }
    }

    void WinCondition()
    {
        Shared_EventsManager.GameHasBeenWon();
        WinGame = true;
    }


    void TimerLength()
    {
        TimerEnded = true;
        EndGame();
    }

    void EndGame()
    {
        if (WinGame == true && TimerEnded == true)
        {
            print("Winner!");
            Shared_EventsManager.GameHasBeenWon();
        }
        else
        {
            print("Failure!");
            Shared_EventsManager.GameHasBeenLost();
        }
    }
    // if i want a new question, i only need to run start again, if i want to count successful answers i will need a variable that is not set in start


}
