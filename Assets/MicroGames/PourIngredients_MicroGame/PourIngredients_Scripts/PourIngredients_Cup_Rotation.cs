using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourIngredients_Cup_Rotation : MonoBehaviour
{
    private bool boolPourIngredients;

    void OnEnable()
    {
        PourIngredients_EventManager.PouredIngredients += PouringCupAntiClockwise;
        PourIngredients_EventManager.CupReturn += PouringCupClockwise;
    }
    void OnDisable()
    {
        PourIngredients_EventManager.PouredIngredients += PouringCupAntiClockwise;
        PourIngredients_EventManager.CupReturn += PouringCupClockwise;
    }
    
    void Start()
    {
        boolPourIngredients = false;
    }

    void Update()
    {
        if(boolPourIngredients == true)
        {
            this.transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
        }
            else if(boolPourIngredients == false)
        {
            this.transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
        }
    }

    void PouringCupAntiClockwise()
    {
        print("Tip Cup Left");
        boolPourIngredients = true;
    }

    void PouringCupClockwise()
    {
        print("Return Cup Right");
        boolPourIngredients = false;
    }

}
