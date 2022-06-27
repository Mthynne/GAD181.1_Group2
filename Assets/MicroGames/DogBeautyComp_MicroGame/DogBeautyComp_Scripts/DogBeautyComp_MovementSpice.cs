using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBeautyComp_MovementSpice : MonoBehaviour
{
    private bool spinningEntertainment = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(spinningEntertainment == true)
        {
            this.transform.Rotate(new Vector3(45, 90, -90) * Time.deltaTime);
        }
    }
}
