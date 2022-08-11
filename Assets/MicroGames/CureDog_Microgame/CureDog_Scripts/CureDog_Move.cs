using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureDog_Move : MonoBehaviour
{
    void OnEnable()
    {
        CureDog_EventManager.PouredPotion += PouringOn;
        CureDog_EventManager.NoPotion += PouringOff;
    }
    void OnDisable()
    {
        CureDog_EventManager.PouredPotion -= PouringOn;
        CureDog_EventManager.NoPotion -= PouringOff;
    }

    void PouringOn()
    {
        this.GetComponent<Animator>().SetTrigger("CuringDoggo");
    }

    void PouringOff()
    {
        this.GetComponent<Animator>().SetTrigger("CuringDoggo");
    }
}
