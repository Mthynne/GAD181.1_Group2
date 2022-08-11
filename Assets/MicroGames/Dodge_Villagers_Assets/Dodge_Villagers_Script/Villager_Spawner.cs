            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;

            public class Villager_Spawner: MonoBehaviour
            {
            public GameObject villagerPrefab;
            public float respawnTime = 1f;
            private Vector2 screenBounds;
            private bool spawner = true;
            // Start is called before the first frame update

            private void OnEnable()
            {
            Shared_EventsManager.CompleteGame += stopspawn;
            Shared_EventsManager.LostTheGame += stopspawn;
            }

            private void OnDisable()
            {
            Shared_EventsManager.CompleteGame -= stopspawn;
            Shared_EventsManager.LostTheGame -= stopspawn; 

            }


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
            while(spawner == true)
            {
            yield return new WaitForSeconds(respawnTime);
            spawnvillager();

            }

            }

            void stopspawn()
            {
            Destroy(GameObject.FindWithTag("Villagers"));   
            spawner = false;
            StartCoroutine(villagerspawn());
            }
            }
