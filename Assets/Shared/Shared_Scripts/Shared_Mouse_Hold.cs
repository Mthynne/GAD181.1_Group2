using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_Mouse_Hold : MonoBehaviour
{
    
    void Update()
    {
        //handles left mouse button hold
        if(Input.GetMouseButtonDown(0))
        {
            print("Mouse Held Down");
            Shared_EventsManager.HeldMouse();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            print("Mouse Released");
            Shared_EventsManager.NoMouseInput();
        }

    }
}
