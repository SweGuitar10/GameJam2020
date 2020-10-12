using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    SoundScripts sound;
    private void Start()
    {
        sound = GameObject.Find("SoundLily").GetComponent<SoundScripts>();

        sound.playMenuMusic();
    }

    public void startGame()
    {
        sound.stopMenuMusic();
        sound.stopRainSound();
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
}
