using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIngredientsManager : MonoBehaviour
{
    private int correctAnswer;

    public GameObject[] Apple, Orange, Tomato, Cherry, Lime;
    //I will likely need: a public array of sprites

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        correctAnswer = Random.Range(1, 6);
        // Look into how to change a ui image sprite in code


    }




    public void PlayerAnswer(int answerButtonID)
    {
        print("You have selected the " + answerButtonID);

        if(answerButtonID == correctAnswer)
        {
            Debug.Log("You win");
        }
    }


    // if i want a new question, i only need to run start again, if i want to count successful answers i will need a variable that is not set in start
}
