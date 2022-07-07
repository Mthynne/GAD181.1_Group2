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
        play.gameObject.SetActive(true);
        options.gameObject.SetActive(true);
        credits.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        Return.gameObject.SetActive(false);
        fullscreenBTN.gameObject.SetActive(false);
    }
}
