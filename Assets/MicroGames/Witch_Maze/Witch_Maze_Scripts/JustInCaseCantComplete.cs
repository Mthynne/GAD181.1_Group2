using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JustInCaseCantComplete : MonoBehaviour
{
    public void SkipGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Shared_EventsManager.GameHasBeenWon();
    }
}
