using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_Space_Hold : MonoBehaviour
{
    void Update()
    {
        //handles left mouse button hold
        if(Input.GetKeyDown("space"))
        {
            print("Space Held Down");
            //event is still mouse input because I only recently changed it to space bar input
            Shared_EventsManager.HeldMouse();
        }
        else if(Input.GetKeyUp("space"))
        {
            print("Space Released");
            //event is still mouse input because I only recently changed it to space bar input
            Shared_EventsManager.NoMouseInput();
        }
    }
}
