using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Spawner: MonoBehaviour
{
    public GameObject villagerPrefab;
    public float respawnTime = 1.9f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(villagerspawn());
    }

    private void spawnvillager()
    {
        GameObject a = Instantiate(villagerPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, -4);
    }

    IEnumerator villagerspawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnvillager();
        }

    }
}
