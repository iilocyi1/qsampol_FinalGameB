using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameTime = 10;

    float totalTimeElapsed = 0;
    bool isGameOver = false;

    void Update()
    {
        if (isGameOver)
            return;

        totalTimeElapsed += Time.deltaTime;
        gameTime -= Time.deltaTime;

        if (gameTime <= 0)
            isGameOver = true;
    }

    public void AdjustTime(float amount)
    {
        gameTime += amount;

    }

    void OnGUI()
    {
        if (!isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            GUI.Box(boxRect, "Time");

            Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(labelRect, ((int)gameTime).ToString());
        }

        else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            GUI.Box(boxRect, "GAME OVER");
            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
            GUI.Label(labelRect, "Total Time: " + (int)totalTimeElapsed);

            Time.timeScale = 0;
        }
    }
}
