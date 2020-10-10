using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMScript : MonoBehaviour
{
    private static BPMScript bpmScriptInstance;
    public float bpm = 120;
    private float beatInterval, beatTimer, beatInterval8, beatTimer8;
    public static bool beatFull, beat8;
    public static int beatCountFull, beatCount8;

    private void Awake()
    {
        if(bpmScriptInstance != null && bpmScriptInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            bpmScriptInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }


    private void Update()
    {
        beatDetection();
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
            Debug.Log(4);
        }

        beat8 = false;
        beatInterval8 = beatInterval / 2;
        beatTimer8 += Time.deltaTime;
        if (beatTimer8 >= beatInterval8)
        {
            beatTimer8 -= beatInterval8;
            beat8 = true;
            beatCount8++;
            Debug.Log(8);
        }

    }
}
