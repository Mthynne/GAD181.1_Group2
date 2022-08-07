using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_SceneChanger : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    
    
    public void SceneChange()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
