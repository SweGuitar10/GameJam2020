using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public TMP_Text text;
    public GameObject textGo;
    public Points point;
    bool first;
    bool second;

    SoundScripts sound;
    
    
    void Start()
    {
        text.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
        point = GameObject.Find("Player").GetComponent<Points>();
        sound = GameObject.Find("SoundLily").GetComponent<SoundScripts>();
        first = true;
    }

    void Update()
    {
        setHighscore();
    }

    public void setHighscore()
    {
        if (PlayerPrefs.GetInt("Highscore") < point.points)
        {
            PlayerPrefs.SetInt("Highscore", point.points);
            text.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
            if (first && point.points > 0)
            {
                first = false;
                second = true;
                blinkingHighScore();
            }

            if (second)
            {
                sound.playHighscore();
                second = false;
            }
        }

    }

    public void resetHighscore()
    {
        PlayerPrefs.SetInt("Highscore", 0);
    }

    public void blinkingHighScore()
    {
        StartCoroutine(Wait(.2f));
    }
    IEnumerator Wait(float sec)
    {
        textGo.SetActive(false);
        yield return new WaitForSeconds(sec);
        textGo.SetActive(true);
        yield return new WaitForSeconds(sec);

        textGo.SetActive(false);
        yield return new WaitForSeconds(sec);
        textGo.SetActive(true);
        yield return new WaitForSeconds(sec);

        textGo.SetActive(false);
        yield return new WaitForSeconds(sec);
        textGo.SetActive(true);


    }
}
