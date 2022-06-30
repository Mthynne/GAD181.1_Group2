using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_SceneManager : MonoBehaviour
{
    void OnEnable()
    {

    }
    void OnDisable()
    {

    }

    public void LoadNextLevel()
    {
        //This will load the next scene in the buildIndex, if in scene 2 go to scene 3
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
