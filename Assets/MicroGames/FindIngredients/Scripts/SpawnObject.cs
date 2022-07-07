using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    Vector2 randomPosition;
    public float xRange = 3f;
    public float yRange = 3f;

    void Start()
    {


        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(0 - yRange, 0 + yRange);

        randomPosition = new Vector2(xPosition, yPosition);

        transform.position = randomPosition;




    }


}
