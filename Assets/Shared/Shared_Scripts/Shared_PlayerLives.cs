using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shared_PlayerLives : MonoBehaviour
{
    private int playersLives;

    public GameObject livesUI_1;
    public GameObject livesUI_2;
    public GameObject livesUI_3;

    void OnEnable()
    {
        Shared_EventsManager.CompleteGame += IncreaseLives;
        Shared_EventsManager.LostTheGame += DecreaseLives;
        Shared_EventsManager.PlayerDead += DecreaseLives;
    }
    void OnDisable()
    {
        Shared_EventsManager.CompleteGame -= IncreaseLives;
        Shared_EventsManager.LostTheGame -= DecreaseLives;
        Shared_EventsManager.PlayerDead -= DecreaseLives;
    }

    void Awake()
    {
        //set int playerlives to obtained pref int;
        playersLives = PlayerPrefs.GetInt("Lives");
    }

    // Start is called before the first frame update
    void Start()
    {
        if(playersLives == 3)
        {
            ThreeLivesDisplay();
        }
        else if(playersLives == 2)
        {
            TwoLivesDisplay();
        }
        else if(playersLives == 1)
        {
            OneLivesDisplay();
        }
    }

    void ThreeLivesDisplay()
    {
        livesUI_1.SetActive(true);
        livesUI_2.SetActive(true);
        livesUI_3.SetActive(true);
    }

    void TwoLivesDisplay()
    {
        livesUI_1.SetActive(true);
        livesUI_2.SetActive(true);
        livesUI_3.SetActive(false);
    }

    void OneLivesDisplay()
    {
        livesUI_1.SetActive(true);
        livesUI_2.SetActive(false);
        livesUI_3.SetActive(false);
    }

    void IncreaseLives()
    {
        //set player pref to int 3;
    	PlayerPrefs.SetInt("Lives", 3);
    }

    void DecreaseLives()
    {
        playersLives--;
        print(playersLives);
        PlayerPrefs.SetInt("Lives", playersLives);
        LoseScreen();
    }

    void LoseScreen()
    {
        if(playersLives <= 0)
        {
            PlayerPrefs.SetInt("Lives", 3);
            SceneManager.LoadScene("LoseScene");
        }
    }
}
