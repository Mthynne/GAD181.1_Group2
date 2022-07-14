using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutscenePlayer : MonoBehaviour
{
    VideoPlayer IntroCutsceneVid;

    void Awake()
    {
        IntroCutsceneVid = GetComponent<VideoPlayer>();
        IntroCutsceneVid.Play();
        IntroCutsceneVid.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
