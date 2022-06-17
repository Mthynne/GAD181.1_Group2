using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureDog_Particle_Pouring : MonoBehaviour
{
    ParticleSystem potionParticles; //pouring particle effect
    private bool particleStatus; //whether to pour or not

    void OnEnable()
    {
        CureDog_EventManager.PouredPotion += PotionOn;
        CureDog_EventManager.NoPotion += PotionOff;
    }
    
    void OnDisable()
    {
        CureDog_EventManager.PouredPotion -= PotionOn;
        CureDog_EventManager.NoPotion -= PotionOff;
    }
    
    void Start()
    {
        potionParticles = this.GetComponent<ParticleSystem>(); //fetch pouring particle system
    }


    void PotionOn()
    {
        print("Potion is on");
        potionParticles.Play(); //start particles
    }

    void PotionOff()
    {
        print("Potion is off");
        potionParticles.Stop(); //stop particles
    }

}
