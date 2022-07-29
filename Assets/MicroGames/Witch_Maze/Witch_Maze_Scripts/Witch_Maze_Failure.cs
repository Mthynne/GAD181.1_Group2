using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch_Maze_Failure : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {

            Destroy(collision.gameObject);
            Shared_EventsManager.TimerPause();
            Shared_EventsManager.GameHasBeenLost();
        }

    }

}


