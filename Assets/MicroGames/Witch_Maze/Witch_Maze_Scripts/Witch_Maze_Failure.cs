using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Maze_Failure : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
           
            Destroy(collision.gameObject);
            Debug.Log("Failure!");
        }

    }
}
