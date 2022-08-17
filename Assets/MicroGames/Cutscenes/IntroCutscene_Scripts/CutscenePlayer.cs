using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutscenePlayer : MonoBehaviour
{
    //detects the video that it wants to play
    VideoPlayer IntroCutsceneVid; 

    void Awake()
    {
        //get the video
        //play the video
        //when the video reaches the end of the video, change the scene

        IntroCutsceneVid = GetComponent<VideoPlayer>(); //this grabs the video so there is something to play
        IntroCutsceneVid.Play(); //this plays the video
        IntroCutsceneVid.loopPointReached += CheckOver; //this checks to see if its at the loop point and when it is it will start CheckOver().
    }

    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            SkipCutscene();
        }
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //change the scene when the video reaches the end.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void SkipCutscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);        
    }
}
