using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Options : MonoBehaviour
{
    //the mainmenu UI
    public GameObject play;
    public GameObject options;
    public GameObject credits;
    public GameObject exit;
    
    //in the options menu ui
    public GameObject Return;
    public GameObject fullscreenBTN;


    public void OptionsClick()
    {
        //when the options button is pressed
            //make the play button disappear 
            //make the options button disappear 
            //make the credits button disappear
            //make the exit button disappear
            //make the return button appear
            //make the fullscreen button appear

        play.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        Return.gameObject.SetActive(true);
        fullscreenBTN.gameObject.SetActive(true);
    }
}
