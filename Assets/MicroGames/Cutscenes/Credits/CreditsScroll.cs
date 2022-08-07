using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroll : MonoBehaviour
{
    public float speed; //set in editor through testing

    void Update()
    {
        this.transform.position+=Vector3.up*speed;
    }
    
}
