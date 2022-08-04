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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GainedPoints();
            WinCondition();

        }

        if(score >= 10)
        {

            source2.PlayOneShot(SFX2);

        }

    }

        

    void GainedPoints()
    {

        score += 1;
        pointsScore.text = "Pets: " + score;
        

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
