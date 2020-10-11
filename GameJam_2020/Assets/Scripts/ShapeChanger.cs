using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : MonoBehaviour
{
    public GameObject cube, sphere, triangle;
    int shape;
    SoundScripts sound;

    private void Start()
    {
        sound = GameObject.Find("SoundLily").GetComponent<SoundScripts>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            sound.playShapeShift();
            shape = 0;
            changeShape(shape);
           
        }

        if (Input.GetKey(KeyCode.K))
        {
            sound.playShapeShift();
            shape = 1;
            changeShape(shape);
        }

        if (Input.GetKey(KeyCode.L))
        {
            sound.playShapeShift();
            shape = 2;
            changeShape(shape);
        }
    }

    private void changeShape(int shape)
    {
        switch(shape)
        {
            case 0:
                cube.SetActive(true);
                sphere.SetActive(false);
                triangle.SetActive(false);
                break;
            case 1:
                cube.SetActive(false);
                sphere.SetActive(true);
                triangle.SetActive(false);
                break;
            case 2:
                cube.SetActive(false);
                sphere.SetActive(false);
                triangle.SetActive(true);
                break;
            default:
                Debug.Log("Shapeshift error!");
                break;
        }
    }

    public int getShape()
    {
        return shape;
    }
}
