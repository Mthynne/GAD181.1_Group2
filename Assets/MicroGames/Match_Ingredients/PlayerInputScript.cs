using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    enum Answer {Apple, Orange, Banana, Grapes, Melon };

    public float clickCount;


   /* void Start()
    {
        Answer myAnswer;

        myAnswer = playerInput;
    } */

   /* public void playerInput()
    {
        
    } */


    void OnMouseDown()
    {
        clickCount += 1;

        Debug.Log(gameObject.name);
        Debug.Log(clickCount);


    }

}
