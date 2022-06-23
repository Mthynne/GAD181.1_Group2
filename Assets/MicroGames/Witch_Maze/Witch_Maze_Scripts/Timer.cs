using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    [SerializeField] float countdownTime;
    private bool isCounting;
    

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
