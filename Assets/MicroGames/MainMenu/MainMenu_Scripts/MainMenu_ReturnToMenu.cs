using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_ReturnToMenu : MonoBehaviour
{
    public GameObject play;
    public GameObject options;
    public GameObject credits;
    public GameObject exit;
    public GameObject Return;
    public GameObject fullscreenBTN;

    public void ReturnClick()
    {
        //when the return button is pressed
            //make the play button appear
            //make the options button appear
            //make the credits button appear
            //make the exit button appear
            //make the return button disappear
            //make the fullscreen button disappear

        play.gameObject.SetActive(true);
        options.gameObject.SetActive(true);
        credits.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        Return.gameObject.SetActive(false);
        fullscreenBTN.gameObject.SetActive(false);
    }
}
