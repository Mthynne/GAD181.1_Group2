using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureDog_FillingUp : MonoBehaviour
{
    private bool dogFullStatus = false; //to cap it
    private bool potionActivate = false; //for whether to pour or not
    private float intPourTime = 0.0f; //counter for holding **needs Work - Oscar**
    private int seconds;

    void OnEnable()
    {
        CureDog_EventManager.PouredPotion += PotionCount;
        CureDog_EventManager.NoPotion += PotionFreeze;
    }
    
    void OnDisable()
    {
        CureDog_EventManager.PouredPotion -= PotionCount;
        CureDog_EventManager.NoPotion -= PotionFreeze;
    }

    void Update()
    {
        //if (the mouse button is being held down)
        //{
            //increase the number by one every second
        //}

        //else if the mouse is NOT being held down
        //{
            //stop the timer at whatever value it is at
        //}
        
        if(potionActivate == true)
        {
            TimerPouring();
        }
        else if(potionActivate == false)
        {
            TimerResetPour();
        }
    }

    void PotionCount()
    {   
        //Is the Mouse being held?
        //Should the game be running as if it is running?
        //Yes it should
        potionActivate = true;
    }

    void PotionFreeze()
    {   
        //Is the Mouse being held?
        //Should the game be running as if it is running?
        //No it shouldn't
        potionActivate = false;
    }

    void TimerPouring()
    {
        //increase value of timer
        //print value in console
        //if(the timer reaches the value of 6)
        //{
            //win the game
            //print win
        //}
        
        //seconds
        intPourTime += Time.deltaTime;
        //turn float into seconds
        seconds = (int)(intPourTime % 60);
        print(intPourTime);
                
        if(intPourTime >= 6f)
        {
            print("win");
            dogFullStatus = true;
        }
    }

    void TimerResetPour()
    {
        //reset the value of the timer back to 0 and keep at 0 until turned on.

        //seconds
        intPourTime = Time.deltaTime;
        //turn float into seconds
        seconds = (int)(intPourTime % 60);
        print(intPourTime);
    }

}