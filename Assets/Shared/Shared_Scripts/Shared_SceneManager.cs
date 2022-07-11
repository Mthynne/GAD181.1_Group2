using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shared_SceneManager : MonoBehaviour
{
    //We use 2 bools so we know whether we are retrying the scene or whether we are moving to the next scene. 
    private bool sceneSwap; //this determains whether we are changing to the next scene in the order.
    private bool sceneRetry; //this determains whether we are repeating the same scene because the player lost.


    //we then (for now) are using 2 buttons as the displays for lose or win (this will be changed to 
    //images later however for now they work)
    public GameObject FailedBTN; //LoseButton or LoseScreen
    public GameObject WinBTN; //WinButton or WinScreen


    //these events help with determining whether the game was lost or won, 
    //if lost in your game script run the complete game event in your games script, 
    //if lost in your game run the lost game event in your games script.
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
    
    
    //we need to make sure that the bools and buttons are set to false so they dont appear or start 
    //the win or lose function yet.
    void Start()
    {
        FailedBTN.SetActive(false); //failed button off
        WinBTN.SetActive(false);    //won button off
        sceneSwap = false;          //SceneSwap off
        sceneRetry = false;         //SceneRetry off
    }


    //if either bools become true itll run a coroutine (Timer) to hold the buttons on the screen for 5 
    //seconds before moving onto the next scene.
    void Update()
    {
        //if(the game was successfully completed)
        //{
            //Then start a timer to swap the scene.    
        //}
        if(sceneSwap == true)
        {
            float delayForSceneSwap = 3f;
            StartCoroutine(LoadNewSceneAfterDelay(delayForSceneSwap));
        }
        
        //if(the game was failed)
        //{
            //Then start a timer to restart the scene.    
        //}
        if(sceneRetry == true)
        {
            float delayForSceneSwap = 3f;
            StartCoroutine(LoadSameSceneAfterDelay(delayForSceneSwap));
        }
    }
    

    //timer for loading the next scene in the list, called from the sceneSwap update.
    IEnumerator LoadNewSceneAfterDelay(float delayForSceneSwap)
    {
        yield return new WaitForSeconds(delayForSceneSwap);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    
    //timer for reloading the scene that was playing, called from the sceneRetry update.
    IEnumerator LoadSameSceneAfterDelay(float delayForSceneSwap)
    {
        yield return new WaitForSeconds(delayForSceneSwap);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    

    //This are the function the event CompleteGame goes to in order to change the micro game. 
    void ProgressStartSwapTimer()
    {
        WinBTN.SetActive(true);
        sceneSwap = true;
    }


    //This are the function the event LostTheGame goes to in order to replay the same micro game.
    void StartRetryTimer()
    {
        FailedBTN.SetActive(true);
        sceneRetry = true;
    }
}
