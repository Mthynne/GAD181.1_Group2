using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailedTransition_5SecTimer : MonoBehaviour
{
    private float countdownTillTransition = 5f;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Tick()); //start the timer
    }

    IEnumerator Tick()
    {
        //if the countdown time is less then 0.1
        //{
            //run event to change the scene
        //}
        //else
        //{
            //tick down by one second more
            //repeat
        //}

        if (countdownTillTransition <= 0.1f) 
        {
            TimerFinished();
        }
        else
        {
            yield return new WaitForSecondsRealtime(1f);

            countdownTillTransition--;
            StartCoroutine(Tick());
        }
    }
    
    //Runs the Timer done event.
    void TimerFinished()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
