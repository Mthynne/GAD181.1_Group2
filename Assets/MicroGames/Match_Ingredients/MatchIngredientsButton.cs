using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIngredientsButton : MonoBehaviour
{
    public int buttonID;
    public MatchIngredientsManager myManager;
    
    
    public void ButtonAction()
    {
        //Tell game manager button id
        Debug.Log(buttonID);
        myManager.PlayerAnswer(buttonID);

    }






}
