using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_Space_Click : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       //handles left mouse click hold
        if(Input.GetButtonDown("Jump"))
        {
            print("Space clicked");
            //event is still mouse input because I only recently changed it to space bar input
            Shared_EventsManager.HeldMouse();
        } 
    }
}
