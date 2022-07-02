using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dodge_Scene_Transition : MonoBehaviour
{
    private bool sceneSwap;
    private bool sceneRetry;

    public GameObject failedBTN; //using button for now as I have no image
    public GameObject WinBTN; //using button for now as I have no image

    void OnEnable()
    {
        Shared_EventsManager.CompleteGame += ProgressStartSwapTimer; //from the "Shared_EventsManager"
        Shared_EventsManager.LostTheGame += StartRetryTimer; //from the "Shared_EventsManager"
    }
    void OnDisable()
    {
        Shared_EventsManager.CompleteGame -= ProgressStartSwapTimer; //from the "Shared_EventsManager"
        Shared_EventsManager.LostTheGame -= StartRetryTimer; //from the "Shared_EventsManager"
    }

    void Start()
    {
        failedBTN.SetActive(false);
        WinBTN.SetActive(false);
        sceneSwap = false;
        sceneRetry = false;
    }
    // Update is called once per frame
    void Update()
    {
        //if(the game was successfully completed)
        //{
        //Then start a timer to swap the scene.    
        //}
        if (sceneSwap == true)
        {
            float delayForSceneSwap = 2f;
            StartCoroutine(LoadNewSceneAfterDelay(delayForSceneSwap));
        }

        //if(the game was failed)
        //{
        //Then start a timer to restart the scene.    
        //}
        if (sceneRetry == true)
        {
            float delayForSceneSwap = 2f;
            StartCoroutine(LoadSameSceneAfterDelay(delayForSceneSwap));
        }
    }

    //timer for loading the next scene in the list.
    IEnumerator LoadNewSceneAfterDelay(float delayForSceneSwap)
    {
        yield return new WaitForSeconds(delayForSceneSwap);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //timer for reloading the scene that was playing
    IEnumerator LoadSameSceneAfterDelay(float delayForSceneSwap)
    {
        yield return new WaitForSeconds(delayForSceneSwap);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void ProgressStartSwapTimer()
    {
        WinBTN.SetActive(true);
        sceneSwap = true;
    }

    void StartRetryTimer()
    {
        failedBTN.SetActive(true);
        sceneRetry = true;
    }
}
