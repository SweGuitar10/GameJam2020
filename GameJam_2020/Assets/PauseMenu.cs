﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;
    ShapeChanger shape;
    // Start is called before the first frame update
    void Start()
    {
        shape = GameObject.Find("Player").GetComponent<ShapeChanger>();
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
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        shape.enabled = !isPaused;
        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    public void mainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
