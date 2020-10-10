using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    ShapeChanger shapeCh;
    DestroyWall destroyWall;
    private void Start()
    {
        shapeCh = gameObject.GetComponent<ShapeChanger>();

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

        if(hit.gameObject.CompareTag(tag))
        {
            Destroy(hit.gameObject);
            Points.points++;
        }
        else
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }

    }
    

}
