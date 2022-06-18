using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourIngredients_EventManager : MonoBehaviour
{
    void OnEnable()
    {
        Shared_EventsManager.MouseHold += TipCup; //from the "Shared_EventsManager"
        Shared_EventsManager.MouseLetGo += RepostitionCup; //from the "Shared_EventsManager"
    }
    void OnDisable()
    {
        Shared_EventsManager.MouseHold -= TipCup; //from the "Shared_EventsManager"
        Shared_EventsManager.MouseLetGo -= RepostitionCup; //from the "Shared_EventsManager"
    }
    
    //Tipping On
    public delegate void CupTipping();
    public static event CupTipping PouredIngredients;

    public static void TipCup()
    {
        PouredIngredients();
    }

    //Tipping Off
    public delegate void ReturnCup();
    public static event ReturnCup CupReturn;

    public static void RepostitionCup()
    {
        CupReturn();
    }

    //Tipping On
    public delegate void AddedIngredients();
    public static event AddedIngredients AcceptedIngredients;

    public static void IngredientsInPot()
    {
        AcceptedIngredients();   
    }

}
