using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Credits : MonoBehaviour
{
    public GameObject play;
    public GameObject options;
    public GameObject credits;
    public GameObject exit;
    public GameObject Return;

    public void CreditsClick()
    {
        play.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        Return.gameObject.SetActive(true);
    }
}