using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Button_SFX : MonoBehaviour
{
    public AudioSource buttonSFXPlayer;

    public void PlayButtonSFX()
    {
        buttonSFXPlayer.Play();
    }
}
