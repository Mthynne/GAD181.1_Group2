using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    Vector2 randomPosition;

    void Start()
    {
        this.transform.position = new Vector2(Random.Range(-7, 4), Random.Range(-4, 4));
        //on start, the 5 fruits needing to be found are put into random positions on the game screen
         

    }

    


}
