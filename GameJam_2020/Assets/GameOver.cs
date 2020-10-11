using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject player;
    public bool isGameOver = false;
   

    public void gameOver()
    {
        Destroy(player);
        gameOverScreen.SetActive(true);
        isGameOver = true;
        Time.timeScale = 0f;
    }
}
