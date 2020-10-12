using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighscoreMenu : MonoBehaviour
{

    public TMP_Text text;

    void Start()
    {
        text.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        updateHighscore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetHighscore()
    {
        PlayerPrefs.DeleteKey("Highscore");
        updateHighscore();
    }

    void updateHighscore()
    {
        text.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
    }
}
