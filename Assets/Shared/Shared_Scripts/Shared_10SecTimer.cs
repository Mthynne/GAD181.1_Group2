using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shared_10SecTimer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    private float countdownTime = 10.0f;
    private bool isCounting;
    private bool boolBeatTimer;
    

    private void Awake()
    {
        isCounting = true;
        StartCoroutine(Tick());
    }

    IEnumerator Tick()
    {
        
        if (countdownTime <= 0.1f)
        {
            Debug.Log("Failure");
            Shared_EventsManager.DefinatelyLost();
        }

        else
        {
            yield return new WaitForSecondsRealtime(1f);

            countdownTime--;
            StartCoroutine(Tick());
        }

    }


    // Update is called once per frame
    void Update()
    {
        //prints time
        if ((isCounting) && (countdownTime != 0.1f))
        {
            countdownText.text = "TIME LEFT: " + countdownTime.ToString();
        }
    }
}
