using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Maze_Failure : MonoBehaviour
{
    private bool timerended;
    private bool wingame;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {

            Destroy(collision.gameObject);
            Debug.Log("you lose!");
            Shared_EventsManager.GameHasBeenLost();
        }

    }

}


