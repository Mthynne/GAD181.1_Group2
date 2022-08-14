using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
  
    //allows any number of materials to be used
    public Material[] material;
    public AudioSource source;
    public AudioClip SFX;
    private bool TimerEnded;

    Renderer rend;

    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        TimerEnded = false; //timer hasnt ended

    }

    void OnEnable() //enable called event
    {
        Shared_EventsManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"
    }
    void OnDisable() //disable called event
    {
        Shared_EventsManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"
    }

    // Update is called once per frame
    void Update()
    {
        //change water colour when score increases 
        if (MixingAbility.score >= 10)
        {
            //this will change the material to the next colour then play a bubble effect
            rend.sharedMaterial = material[1];
            print("Potion Stage 1 Achieved");
            source.PlayOneShot(SFX);
        }

        if (MixingAbility.score >= 25)
        {
            //this will change the material to the next colour then play a bubble effect
            rend.sharedMaterial = material[2];
            print("Potion Stage 2 Achieved");
            source.PlayOneShot(SFX);
        }

        if (MixingAbility.score >= 40)
        {
            //this will change the material to the next colour then play a bubble effect
            rend.sharedMaterial = material[3];
            print("Potion Stage 3 Achieved");
            source.PlayOneShot(SFX);

        }

                
    }

    void TimerLength()
    {

        TimerEnded = true;
        EndGame();

    }

    void EndGame()
    {

        rend.sharedMaterial = material[0];

    }

}


