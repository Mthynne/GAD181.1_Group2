using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DogBeautyComp_MovementSpice : MonoBehaviour
{
    private bool spinningEntertainment = true;

    private int Clicks = 0;
    public TextMeshProUGUI clapScore;

    void OnEnable()
    {
        DogBeautyComp_EventsManager.CheerTheDogOn += SwitchingSides;
    }
    void OnDisable()
    {
        DogBeautyComp_EventsManager.CheerTheDogOn -= SwitchingSides;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Clicks == 3 || Clicks == 6 || Clicks == 9)
        {
            this.transform.Rotate(new Vector3(90, 180, 0));
        }
        else if(Clicks == 1 || Clicks == 4 || Clicks == 7)
        {
            this.transform.Rotate(new Vector3(90, 0, 0));
        }
    }

    void SwitchingSides()
    {
        Clicks++;
        clapScore.text = "Claps: " + Clicks;
    }

}
