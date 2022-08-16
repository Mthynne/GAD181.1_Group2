using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PettingDog_Ability : MonoBehaviour
{
    //Score starts at 0
    public static int score = 0;

    //These are called from the Time Event Script
    private bool TimerEnded;
    private bool WinGame;

    //These include The UI and Audio
    public TextMeshProUGUI pointsScore;
    public AudioSource source2;
    public AudioClip SFX2;

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
        //When the player hits Space They will call the GainedPoints Fucntion and Check the WinCondition
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GainedPoints();
            WinCondition();

        }

        //Everytime the score is >= 10 it will play a Bark Sound
        if(score >= 10)
        {

            source2.PlayOneShot(SFX2);

        }

    }

        
    //This Function adds 1 point and adds the score to the UI
    void GainedPoints()
    {

        score += 1;
        pointsScore.text = "Pets: " + score;
        

    }

    //This will check once the score has reached 15 or more we will have entered the win condition
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

    //If the win conditon and the timer has ended the player will win otherwise he player will fail.
    void EndGame()
    {
        if (WinGame == true && TimerEnded == true)
        {
            source2.PlayOneShot(SFX2);
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
