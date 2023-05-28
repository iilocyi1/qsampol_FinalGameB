using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject spikesPrefab;
    public float spawnCycle = .5f;

    GameManager manager;
    float elapsedTime;
    bool spawnPowerup = true;

    void Start()
    {
        manager = GetComponent<GameManager>();

    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(powerupPrefab) as GameObject;
            else
                temp = Instantiate(spikesPrefab) as GameObject;

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-25f, 25f);
            position.z = Random.Range(-25f, 25f);
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            elapsedTime = 0;
            spawnPowerup = !spawnPowerup;
        }

    }
}