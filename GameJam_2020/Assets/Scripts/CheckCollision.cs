using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    ShapeChanger shapeCh;
    GameOver gameOver;
    Points points;
    private void Start()
    {
        shapeCh = gameObject.GetComponent<ShapeChanger>();
        gameOver = gameObject.GetComponent<GameOver>();
        points = gameObject.GetComponent<Points>();


    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        int shape = shapeCh.getShape();
        string tag;
        switch (shape)
        {
            case 0:
                tag = "Cube";
                break;
            case 1:
                tag = "Sphere";
                break;
            case 2:
                tag = "Triangle";
                break;
            default:
                tag = "Error";
                break;
        }

        if (hit.gameObject.CompareTag(tag))
        {
            Destroy(hit.gameObject);
            points.points++;
        }

        else if (!hit.gameObject.CompareTag(tag) || hit.gameObject.Equals("Wall"))
        {
            gameOver.gameOver();
            
        }
    }
}
