using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;
    ShapeChanger shape;
    GameOver gameOver;
    SoundScripts sound;
    void Start()
    {
        shape = GameObject.Find("Player").GetComponent<ShapeChanger>();
        gameOver = GameObject.Find("Player").GetComponent<GameOver>();
        sound = GameObject.Find("SoundLily").GetComponent<SoundScripts>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            togglePauseMenu();
        }
    }

    public void togglePauseMenu()
    {
        if (!gameOver.isGameOver)
        {
            isPaused = !isPaused;
            pauseMenu.SetActive(isPaused);
            shape.enabled = !isPaused;
            Time.timeScale = isPaused ? 0.0f : 1.0f;
        }
    }

    public void mainMenu()
    {
        Time.timeScale = 1.0f;
        sound.setMusicInstruments(-1f);
        SceneManager.LoadScene(0);
    }
}
