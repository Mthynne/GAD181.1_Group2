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
        float delayForMenu = 5f;
        StartCoroutine(Tick(delayForMenu)); //start the timer
    }

    IEnumerator Tick(float delayForMenu)
    {
        yield return new WaitForSeconds(delayForMenu);
        SceneManager.LoadScene("MainMenu");
    }
}
