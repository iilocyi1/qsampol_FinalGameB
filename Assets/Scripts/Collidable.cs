using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameManager manager;
    public float timeAmount = 1.5f;

    void OnTriggerEnter(Collider another)
    {
        if (another.tag == "Player")
        {
            manager.AdjustTime(timeAmount);
            Destroy(gameObject);

        }
    }
}
