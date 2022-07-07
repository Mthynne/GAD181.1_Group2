using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Fullscreen : MonoBehaviour
{
    public void ClickFullscreenBTN()
    {
        Screen.fullScreen = !Screen.fullScreen;
        print("screen changed resolution");
    }
}
