using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    ShapeChanger shapeCh;
    GameOver gameOver;
    Points points;

    public GameObject brWallCube, brWallSphere, brWallTriangle;
    GameObject brWallSpawn;
    public GameObject brWall;

    SoundScripts sound;

    private void Start()
    {
        shapeCh = gameObject.GetComponent<ShapeChanger>();
        gameOver = gameObject.GetComponent<GameOver>();
        points = gameObject.GetComponent<Points>();
        sound = GameObject.Find("SoundLily").GetComponent<SoundScripts>();

        //sound.playMusic();

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        int shape = shapeCh.getShape();
        string tag;
        switch (shape)
        {
            case 0:
                tag = "Cube";
                brWallSpawn = brWallCube;
                break;
            case 1:
                tag = "Sphere";
                brWallSpawn = brWallSphere;
                break;
            case 2:
                tag = "Triangle";
                brWallSpawn = brWallTriangle;
                break;
            default:
                tag = "Error";
                break;
        }

        if (hit.gameObject.CompareTag(tag))
        {
            points.points++;
            Destroy(hit.gameObject);

            sound.setWallPitch(points.points);
            sound.playWallHit();

            sound.playPickup();

            switch (points.points)
            {
                case 25:
                case 35:
                case 55:
                case 99:
                    sound.setAnnouncerVoiceline(points.points);
                    sound.playAnnouncer();
                    break;
            }


            GameObject brWall = Instantiate(brWallSpawn);
            brWall.transform.position = gameObject.transform.position;
            StartCoroutine(waitToKill(brWall));
        }


        else if (!hit.gameObject.CompareTag(tag) || hit.gameObject.Equals("Wall"))
        {
            gameOver.gameOver();
            
        }
        else
        {

        }

    }

    IEnumerator waitToKill(GameObject go)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(go);
    }
}
