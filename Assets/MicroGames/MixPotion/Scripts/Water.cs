using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
  
    //allows any number of materials to be used
    public Material[] material;
    public AudioSource source;
    public AudioClip SFX;

    Renderer rend;

    void Start()
    {

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }

    // Update is called once per frame
    void Update()
    {
        //change water colour when score increases 
        if (MixingAbility.score >= 10)
        {

            rend.sharedMaterial = material[1];
            print("Potion Stage 1 Achieved");
            source.PlayOneShot(SFX);
        }

        if (MixingAbility.score >= 25)
        {

            rend.sharedMaterial = material[2];
            print("Potion Stage 2 Achieved");
            source.PlayOneShot(SFX);
        }

        if (MixingAbility.score >= 40)
        {

            rend.sharedMaterial = material[3];
            print("Potion Stage 3 Achieved");
            source.PlayOneShot(SFX);

        }
         
    }

}


