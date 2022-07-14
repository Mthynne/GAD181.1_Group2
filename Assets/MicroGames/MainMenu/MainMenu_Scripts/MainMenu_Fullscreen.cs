using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Fullscreen : MonoBehaviour
{
    public void ClickFullscreenBTN()
    {
        //when the fullscreen button is pressed 
            //if the application is already fullscreen make windowed
            //if the application is already windowed make it fullscreen
            //print in console so we know it works

        Screen.fullScreen = !Screen.fullScreen;
        print("screen changed resolution");
    }
}
