using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourIngredients_Pot_Collision : MonoBehaviour
{
    private int ingredNum;
    
    // Start is called before the first frame update
    void Start()
    {
        ingredNum = 0;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<PourIngredients_Ingredient_Prefab>() != null)
        {
            ingredNum++;
            print("Added ingredient: " + ingredNum);
        }
    }
}
