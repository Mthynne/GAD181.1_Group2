using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Exit : MonoBehaviour
{
    public void ExitClick()
    {
        Application.Quit();
        print("Quit");
    }
}
