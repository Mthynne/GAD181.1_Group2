using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipCutsceneButton : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if the key is pressed before the video ends
        //{
            //skip the cutscene and change the scene earlier then when the video is done. 
        //}
        
        if(Input.GetKeyDown("escape"))
        {
            //change the scene when the key is pressed.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
