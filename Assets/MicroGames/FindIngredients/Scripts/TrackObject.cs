using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackObject : MonoBehaviour
{
    public static string objectName;
    //name of object
    public GameObject objectNameText;
    //text at bottom of game corresponding to the object in the game screen
    public static int remainingObjects = 5;
    //amount of objects, needed for timer to recognise when game is done
    bool winnerofgame = false;

    void OnEnable()
    {
        Shared_EventsManager.LostTheGame += RestartRemainingObjects; //from the "Shared_EventsManager"
    }
    void OnDisable()
    {
        Shared_EventsManager.LostTheGame += RestartRemainingObjects; //from the "Shared_EventsManager"
    }
    void OnMouseDown()
    {
        objectName = gameObject.name;
        //name of object
        Destroy(gameObject);
        //destroying the object clicked
        Destroy(objectNameText);
        //destroying the text of object clicked in the dashboard of game 
        remainingObjects -= 1;
        //keeping track of remaining objects
        WinCondition();
        
    }

    void WinCondition()
    {
        if (remainingObjects <= 0)
        {
            Shared_EventsManager.GameHasBeenWon();
            remainingObjects = 5;
            //if the amount of remaining objects is equal to or less than 0 then the game will go through to the win screen
        }
    }

    void RestartRemainingObjects()
    {
        remainingObjects = 5;
        //if the game is lost and restarted, the amount of remaining objects goes back up to 5
    }
}
