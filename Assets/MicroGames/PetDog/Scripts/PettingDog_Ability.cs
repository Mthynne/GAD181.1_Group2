using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PettingDog_Ability : MonoBehaviour
{
    public static int score = 0;

    public TextMeshProUGUI pointsScore;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            print("pressed");
            score += 10;
            pointsScore.text = "Points: " + score;
            //GainedPoints();
            
            
        }

    }
        

    void GainedPoints()
    {

        score += 10;
        pointsScore.text = "Points: " + score;


    }

}
