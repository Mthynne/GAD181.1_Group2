using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixingAbility : MonoBehaviour
{
    public GameObject Spoon;

   
    public float movementSpeed = 10f;

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.A))
        {
            Spoon.transform.localScale = new Vector3(1f, 0, 0);
            print("A key was pressed");
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {

            Spoon.transform.localScale = new Vector3(-1f, 0, 0);
            print("D key was pressed");

        }
        



    }
}
