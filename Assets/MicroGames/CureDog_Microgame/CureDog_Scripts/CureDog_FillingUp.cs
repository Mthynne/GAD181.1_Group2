using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureDog_FillingUp : MonoBehaviour
{
    private bool dogFullStatus = false; //to cap it
    private bool potionActivate = false; //for whether to pour or not
    private int intPourTime = 0; //counter for holding **needs Work - Oscar**

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
        //
        if(potionActivate == true)
        {
            //somethings not working here ****
            if((int)Time.time > intPourTime && dogFullStatus == false) //timer
            {
                intPourTime++;
                intPourTime = (int)Time.time; //pour to the time
                print(intPourTime);
                
                if(intPourTime == 6)
                {
                    print("win");
                    dogFullStatus = true;
                }
            }
            else if(potionActivate == false)
            {
                intPourTime = 0; //if turned off **ideally** reset timer to 0
            }
        }
    }

    void PotionCount()
    {
        potionActivate = true;
        Update();
    }

    void PotionFreeze()
    {
        potionActivate = false;
        Update();
    }
}