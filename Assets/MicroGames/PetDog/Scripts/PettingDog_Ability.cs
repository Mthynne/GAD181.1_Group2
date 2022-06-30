using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PettingDog_Ability : MonoBehaviour
{
    public static int score = 0;

    public Text pointsScore;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {

            GainedPoints();
            
            
        }

    }
        

    void GainedPoints()
    {

        score += 10;
        pointsScore.text = "Points: " + score;


    }

}
