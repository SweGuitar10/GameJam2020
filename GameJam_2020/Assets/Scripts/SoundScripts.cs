﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScripts : MonoBehaviour
{

    FMOD.Studio.EventInstance pickup;
    FMOD.Studio.EventInstance wallHit;
    FMOD.Studio.EventInstance mainLevelMusic;
    FMOD.Studio.EventInstance announcer;
    FMOD.Studio.EventInstance highscore;
    FMOD.Studio.EventInstance death;

    public void setWallPitch(int a)
    {
        wallHit.setParameterByName("Pickups", a);
    }

    public void setAnnouncerVoiceline(int a)
    {
        announcer.setParameterByName("Pickups", a);
    }

    public void setMusicInstruments(float a)
    {
        mainLevelMusic.setParameterByName("LVL", a);
    }

    public void playHighscore()
    {
        highscore.start();
    }

    public void playAnnouncer()
    {
        announcer.start();
    }

    public void playMusic()
    {
        mainLevelMusic.start();
    }

    public void playWallHit()
    {
        wallHit.start();
        
    }

    public void playPickup()
    {
        pickup.start();
    }

    public void playDeat()
    {
        death.start();
    }


    // Start is called before the first frame update
    void Start()
    {
        pickup = FMODUnity.RuntimeManager.CreateInstance("event:/Pickup");
        wallHit = FMODUnity.RuntimeManager.CreateInstance("event:/WallHit");
        mainLevelMusic= FMODUnity.RuntimeManager.CreateInstance("event:/MainLevelMusic");
        announcer = FMODUnity.RuntimeManager.CreateInstance("event:/Announcer");
        highscore = FMODUnity.RuntimeManager.CreateInstance("event:/Highscore");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
