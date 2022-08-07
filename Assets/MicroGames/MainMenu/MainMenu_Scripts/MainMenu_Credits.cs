using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("Credits");
    }
}
