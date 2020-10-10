using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    ShapeChanger shapeCh;
    private void Start()
    {
        shapeCh = gameObject.GetComponent<ShapeChanger>();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        int shape = shapeCh.getShape();
        Debug.Log(shape);
        string tag;
        switch (shape)
        {
            case 0:
                tag = "Cube";
                break;
            case 1:
                tag = "Spere";
                break;
            case 2:
                tag = "Triangle";
                break;
            default:
                tag = "Error";
                break;
        }
        if(tag.Equals(hit.gameObject.tag))
        {
            Destroy(hit.gameObject);
        }
        else
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
