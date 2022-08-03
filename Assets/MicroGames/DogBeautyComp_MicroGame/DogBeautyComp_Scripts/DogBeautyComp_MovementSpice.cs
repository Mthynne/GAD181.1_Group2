using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DogBeautyComp_MovementSpice : MonoBehaviour
{
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
        if(Clicks == 5)
        {
            this.GetComponent<Animator>().SetTrigger("StartRoutine");
        }
        else if(Clicks == 20 || Clicks == 40 || Clicks == 60 || Clicks == 80 || Clicks == 100)
        {
            this.GetComponent<Animator>().SetTrigger("FlipDog");
        }
        else if(Clicks == 10 || Clicks == 30 || Clicks == 50 || Clicks == 70 || Clicks == 90)
        {
            this.GetComponent<Animator>().SetTrigger("ReturnDog");
        }
    }

    void SwitchingSides()
    {
        Clicks++;
        clapScore.text = "Claps: " + Clicks + "/50";
    }

}
