using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundScripts : MonoBehaviour
{

    FMOD.Studio.EventInstance pickup;
    FMOD.Studio.EventInstance wallHit;
    FMOD.Studio.EventInstance mainLevelMusic;
    FMOD.Studio.EventInstance announcer;
    FMOD.Studio.EventInstance highscore;
    FMOD.Studio.EventInstance death;
    FMOD.Studio.EventInstance shift;
    FMOD.Studio.EventInstance menuMusic;
    FMOD.Studio.EventInstance rainSound;

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

    public void setWallPan(float a)
    {
        wallHit.setParameterByName("WallhitPan", a);
        shift.setParameterByName("WallhitPan", a);
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

    public void playShapeShift()
    {
        shift.start();
    }

    public void playMenuMusic()
    {
        menuMusic.start();
    }

    public void stopMenuMusic()
    {
        menuMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }

    public void playRainSound()
    {
        rainSound.setParameterByName("LVL", 0f);
        rainSound.start();
    }

    public void stopRainSound()
    {
        rainSound.setParameterByName("LVL", -1f);
    }


    // Start is called before the first frame update
    void Start()
    {
        pickup = FMODUnity.RuntimeManager.CreateInstance("event:/Pickup");
        wallHit = FMODUnity.RuntimeManager.CreateInstance("event:/WallHit");
        mainLevelMusic= FMODUnity.RuntimeManager.CreateInstance("event:/MainLevelMusic");
        announcer = FMODUnity.RuntimeManager.CreateInstance("event:/Announcer");
        highscore = FMODUnity.RuntimeManager.CreateInstance("event:/Highscore");
        death = FMODUnity.RuntimeManager.CreateInstance("event:/Death");
        shift = FMODUnity.RuntimeManager.CreateInstance("event:/Shift");
        menuMusic = FMODUnity.RuntimeManager.CreateInstance("event:/MenuMusic");
        rainSound = FMODUnity.RuntimeManager.CreateInstance("event:/RainLoop");
        stopRainSound();
        playRainSound();
    }
}
