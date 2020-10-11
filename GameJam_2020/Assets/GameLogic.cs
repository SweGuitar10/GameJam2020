using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    GameOver gameOver;
    BPMScript bpmScript;
    SpawnWall spawnWall;
    Points points;
    Movement move;

    public float changeRateBPM = 7f;
    public float changeRateWall = 5f;
    public float changeRateSpeed = 1.2f;
    bool change = true;

    void Start()
    {
        gameOver = gameObject.GetComponentInChildren<GameOver>();
        spawnWall = gameObject.GetComponentInChildren<SpawnWall>();
        points = gameObject.GetComponentInChildren<Points>();
        bpmScript = GameObject.Find("BPM").GetComponent<BPMScript>();
        move = gameObject.GetComponentInChildren<Movement>();

        bpmScript.bpm = 70f;
        spawnWall.spawnDist = 150f;
    }

    void Update()
    {
        if (gameOver.isGameOver)
        {
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(1);
            }
        }

        if (points.points % 4 == 0)
        {
            change = true;
        }
        else if (change && points.points > 0 && points.points % 7 == 0)
        {
            bpmScript.bpm += changeRateBPM;
            spawnWall.spawnDist -= changeRateWall;
            move.forwardSpeed += changeRateSpeed;
            change = false;
            
        }
    }
}
