using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PettingDog_Ability : MonoBehaviour
{
    public static int score = 0;
    private bool TimerEnded;
    private bool WinGame;
    public TextMeshProUGUI pointsScore;

    void OnEnable() //enable called event
    {
        Shared_EventsManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"
    }
    void OnDisable() //disable called event
    {
        Shared_EventsManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"
    }

    void Start()
    {
        TimerEnded = false; //timer hasnt ended
        WinGame = false; //game hasn't won 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            GainedPoints();
            WinCondition();

        }

    }
        

    void GainedPoints()
    {

        score += 10;
        pointsScore.text = "Points: " + score;


    }

    void WinCondition()
    {
        if (score >= 15)
        {

            WinGame = true;

        }


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

}
