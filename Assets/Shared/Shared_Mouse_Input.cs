using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shared_Mouse_Input : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("Holding Mouse");
        }
        else if(Input.GetMouseButtonUp(0))
        {
            print("Released Mouse");
        }
    }
}
