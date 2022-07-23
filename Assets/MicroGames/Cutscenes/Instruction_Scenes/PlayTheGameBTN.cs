using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayTheGameBTN : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("return"))
        {
            //change the scene to the game when the key or button is pressed.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }

    public void PlayTheGameNow()
    {
        //change the scene to the game when the key or button is pressed.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

}
