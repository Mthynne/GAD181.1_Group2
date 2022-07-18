using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class OutroCutscenePlayer : MonoBehaviour
{
    //detects the video that it wants to play
    VideoPlayer OutroCutsceneVid; 

    void Awake()
    {
        //get the video
        //play the video
        //when the video reaches the end of the video, change the scene

        OutroCutsceneVid = GetComponent<VideoPlayer>(); //this grabs the video so there is something to play
        OutroCutsceneVid.Play(); //this plays the video
        OutroCutsceneVid.loopPointReached += CheckOver; //this checks to see if its at the loop point and when it is it will start CheckOver().
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //change the scene when the video reaches the end.
        SceneManager.LoadScene("MainMenu");
    }
}
