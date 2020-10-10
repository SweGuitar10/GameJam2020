using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    GameOver gameOver;
    void Start()
    {
        gameOver = gameObject.GetComponentInChildren<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver.isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
