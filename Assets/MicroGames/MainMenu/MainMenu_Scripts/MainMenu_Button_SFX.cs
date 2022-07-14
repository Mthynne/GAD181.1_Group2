using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Button_SFX : MonoBehaviour
{
    public AudioSource buttonSFXPlayer; //stores the audio source for the game

    public void PlayButtonSFX()
    {
        //when the button is pressed play the audio source thats been stored
        buttonSFXPlayer.Play();
    }
}
