using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager_SceneManager : MonoBehaviour
{
    public void PlayTheGame()
    {
        //when the play button is pressed chang ethe scene to the next one in the order
        //print in the console so we knwo it works
        Shared_EventsManager.GameHasBeenWon();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        print("Play the game");
    } 

}
