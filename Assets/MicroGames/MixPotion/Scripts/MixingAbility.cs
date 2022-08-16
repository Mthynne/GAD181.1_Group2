using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MixingAbility : MonoBehaviour
{
    //
    public SpriteRenderer spriteRenderer;
    public Sprite SpoonRight;
    public Sprite SpoonLeft;

    //
    public static int score = 0;
    public float movementSpeed = 10f;

    //
    private bool TimerEnded;
    private bool WinGame;
    private bool LeftMovement;
    private bool RightMovement;


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
        LeftMovement = true; //The spoon can move Left
        RightMovement = true; //The spoon can move Right
    }

    // Update is called once per frame
    void Update()
    {
        //When the player hits the A key and LeftMovement is activated it will change the sprite to left as well as add one point. This will also lock the LeftMovement so that it can't be spammed and unlock the RightMovement
        if (Input.GetKeyDown(KeyCode.A) && LeftMovement == true)
        {
            spriteRenderer.sprite = SpoonLeft;
            score += 1;
            print("A key was pressed Score: " + score);
            RightMovement = true;
            LeftMovement = false;
            WinCondition();
            
        }

        //When the player hits the D key and RightMovement is activated it will change the sprite to Right as well as add one point. This will also lock the RightMovement so that it can't be spammed and unlock the LeftMovement
        else if (Input.GetKeyDown(KeyCode.D) && RightMovement == true)  
        {

            spriteRenderer.sprite = SpoonRight;
            score += 1;
            print("D key was pressed Score: " + score);
            LeftMovement = true;
            RightMovement = false;
            WinCondition();

        }

      
   
    }

    //This will check once the score has reached 50 or more we will have entered the win condition
    void WinCondition()
    {
        if(score >= 50)
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
        //If the win conditon and the timer has ended the player will win otherwise he player will fail.
        if (WinGame == true && TimerEnded == true)
        {
            print("Winner!");
            Shared_EventsManager.GameHasBeenWon();
            score = 0;
            LeftMovement = false;
            RightMovement = false;
        }
        else
        {
            print("Failure!");
            Shared_EventsManager.GameHasBeenLost();         
            score = 0;
            LeftMovement = false;
            RightMovement = false;
        }
    }
    
}
