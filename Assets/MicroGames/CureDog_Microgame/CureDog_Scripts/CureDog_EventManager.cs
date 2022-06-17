using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureDog_EventManager : MonoBehaviour
{
    void OnEnable()
    {
        Shared_EventsManager.MouseHold += PotionFalling; //from the "Shared_EventsManager"
        Shared_EventsManager.MouseLetGo += PotionGone; //from the "Shared_EventsManager"
    }

    void OnDisable()
    {
        Shared_EventsManager.MouseHold -= PotionFalling; //from the "Shared_EventsManager"
        Shared_EventsManager.MouseLetGo -= PotionGone; //from the "Shared_EventsManager"
    }

    //pouring on
    public delegate void ParticlePouring();
    public static event ParticlePouring PouredPotion;

    public static void PotionFalling()
    {
        PouredPotion();
    }
    
    //pouring off
    public delegate void ParticleStopped();
    public static event ParticleStopped NoPotion;

    public static void PotionGone()
    {
        NoPotion();
    }

}
