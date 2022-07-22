using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    Vector2 randomPosition;

    void Start()
    {
        //skin tone chicken bone leave me alone
        this.transform.position = new Vector2(Random.Range(-7, 4), Random.Range(-4, 4));
         

    }

    


}
