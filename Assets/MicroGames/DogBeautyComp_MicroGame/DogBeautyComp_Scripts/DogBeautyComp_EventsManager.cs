using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBeautyComp_EventsManager : MonoBehaviour
{
    void OnEnable()
    {
        Shared_EventsManager.MouseHold += CheerMore; //from the "Shared_EventsManager"
    }
    void OnDisable()
    {
        Shared_EventsManager.MouseHold -= CheerMore; //from the "Shared_EventsManager"
    }
    
    //Cheering click
    public delegate void CheeringForDogEvent();
    public static event CheeringForDogEvent CheerTheDogOn;

    public static void CheerMore()
    {
        CheerTheDogOn();
    }
}
