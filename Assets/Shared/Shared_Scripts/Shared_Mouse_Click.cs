using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_Mouse_Click : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       //handles left mouse click hold
        if(Input.GetMouseButtonDown(0))
        {
            print("Mouse clicked");
            Shared_EventsManager.HeldMouse();
        } 
    }
}
