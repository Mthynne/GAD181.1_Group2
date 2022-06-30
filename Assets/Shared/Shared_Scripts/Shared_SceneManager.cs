using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shared_SceneManager : MonoBehaviour
{
    
    void OnEnable()
    {
        Shared_EventsManager.MicroGameSuccess += LoadNextLevel;
        Shared_EventsManager.MicroGameFailed += RedoSameLevel;
    }
    void OnDisable()
    {
        Shared_EventsManager.MicroGameSuccess -= LoadNextLevel;
        Shared_EventsManager.MicroGameFailed += RedoSameLevel;
    }

    public void LoadNextLevel()
    {
        //This will load the next scene in the buildIndex, if in scene 2 go to scene 3
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void RedoSameLevel()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single); //reloads the scene again.
    }
}
