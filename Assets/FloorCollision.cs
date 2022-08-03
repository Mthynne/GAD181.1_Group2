using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    int ingredNum = 0;
    
    void OnCollisionEnter(Collision collision)
    {
        //if the "ingredients" touch the floor
        //{
            //increase the count of ingredients everytime an ingredient lands on the floor
            //run WinCondition()    
        //}
        
        if(collision.gameObject.GetComponent<PourIngredients_Ingredient_Prefab>() != null)
        {
            ingredNum++;
            WinCondition();
        }
    }

    void WinCondition()
    {
        if(ingredNum >= 6)
        {
            Shared_EventsManager.GameHasBeenLost();
        }
    }
    
}
