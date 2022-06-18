using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourIngredients_Ingredient_Prefab : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<PourIngredients_Pot_Collision>() != null)
        {
            Destroy(this.gameObject);
            print("Ingredient deleted");
        }
    }

}
