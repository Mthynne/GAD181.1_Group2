using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MixingAbility : MonoBehaviour
{
    public GameObject Spoon;
    public static int score = 0;
    public float movementSpeed = 10f;
    private bool TimerEnded;
    private bool WinGame;

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

        if (Input.GetKeyDown(KeyCode.A))
        {
            Spoon.transform.position = new Vector3(1f, 0, 0);
            score += 1;
            print("A key was pressed Score: " + score);
            WinCondition();
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {

            Spoon.transform.position = new Vector3(-1f, 0, 0);
            score += 1;
            print("D key was pressed Score: " + score);
            WinCondition();

        }
   
    }

    void WinCondition()
    {
        if(score >= 15)
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);


        }
        else
        {

            print("Failure!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    
}
