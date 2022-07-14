using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Credits : MonoBehaviour
{
    //all UI buttons needed when the credits button is pressed
    public GameObject play;
    public GameObject options;
    public GameObject credits;
    public GameObject exit;
    public GameObject Return;

    public void CreditsClick()
    {
        //when the credits button is pressed
            //turn off play button
            //turn off options button
            //turn off credits button
            //turn off exit button
            //turn on return button
         
        play.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        Return.gameObject.SetActive(true);
    }
}
