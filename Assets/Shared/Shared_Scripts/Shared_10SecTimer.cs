using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shared_10SecTimer : MonoBehaviour
{
    public TextMeshProUGUI countdownText; //controls the countdown text on the UI
    private float countdownTime = 10.0f;  //10 seconds
    private bool isCounting;              //is it counting yes or no          

    private void Awake()
    {
        isCounting = true;      //start counting when scene wakes
        StartCoroutine(Tick()); //start the timer
    }

    //timer function
    IEnumerator Tick()
    {
        //if the countdown time is less then 0.1
        //{
            //run event to see if player won or lost
        //}
        //else
        //{
            //tick down by one second more
            //repeat
        //}

        if (countdownTime <= 0.1f) 
        {
            TimerFinished();
        }
        else
        {
            yield return new WaitForSecondsRealtime(1f);

            countdownTime--;
            StartCoroutine(Tick());
        }
    }

    void Update()
    {
        //prints time 
        if ((isCounting) && (countdownTime != 0.1f))
        {
            countdownText.text = "TIME LEFT: " + countdownTime.ToString();
        }
    }

    //Runs the Timer done event.
    void TimerFinished()
    {
        Shared_EventsManager.TimerDone();
    }
}
