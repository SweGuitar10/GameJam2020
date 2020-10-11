using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMScript : MonoBehaviour
{
    private static BPMScript bpmScriptInstance;
    public float bpm = 120;
    private float beatInterval, beatTimer, beatInterval8, beatTimer8;
    public bool beatFull, beat8;
    public int beatCountFull, beatCount8;

    private int shapeWallSpawn = 0;

    GameOver gameOver;
    SpawnWall spawnWall;
    public GameObject player;

    private void Awake()
    {
        


        

    }
    private void Start()
    {
        if (bpmScriptInstance != null && bpmScriptInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            bpmScriptInstance = this;
        }
        player = GameObject.Find("Player");
        gameOver = player.GetComponentInParent<GameOver>();
        spawnWall = player.GetComponent<SpawnWall>();
    }

    private void Update()
    {
        if (!gameOver.isGameOver)
        {
            beatDetection();
        }
    }

    void beatDetection()
    {
        
        beatFull = false;
        beatInterval = 60 / bpm;
        beatTimer += Time.deltaTime;
        if(beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            beatFull = true;
            beatCountFull++;
            if (shapeWallSpawn == 1)
            {
                spawnWall.spawnShapeWall();
                shapeWallSpawn = 0;

            }
            else
            {
                
                if(Random.Range(0, 6) == 0 && shapeWallSpawn == (0 | 2))
                {
                    spawnWall.spawnFakeWall();
                }
                shapeWallSpawn++;
            }
        }

        beat8 = false;
        beatInterval8 = beatInterval / 2;
        beatTimer8 += Time.deltaTime;
        if (beatTimer8 >= beatInterval8)
        {
            beatTimer8 -= beatInterval8;
            beat8 = true;
            beatCount8++;
        }

    }

    
}
