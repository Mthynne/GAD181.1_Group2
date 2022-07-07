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

    public void CreditsClick()
    {
        play.SetActive(false);
        options.SetActive(false);
        credits.SetActive(false);
        exit.SetActive(false);
    }
}
