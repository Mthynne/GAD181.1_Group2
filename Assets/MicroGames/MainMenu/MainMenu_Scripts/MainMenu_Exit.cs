using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Exit : MonoBehaviour
{
    public void ExitClick()
    {
        //when the exit button is pressed
            //close the application
            //print in console so we know it works
            
        Application.Quit();
        print("Quit");
    }
}
