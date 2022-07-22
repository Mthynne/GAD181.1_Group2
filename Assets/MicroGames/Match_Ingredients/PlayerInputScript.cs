using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    enum Answer {Apple, Orange, Cherry, Tomato, Pear};
    public int ingredientID;
    public float clickCount;


    void OnMouseDown()
    {






        Debug.Log(gameObject.name);
        Debug.Log(clickCount);
        Destroy(gameObject);

        // clickCount += 1;
    }











}
