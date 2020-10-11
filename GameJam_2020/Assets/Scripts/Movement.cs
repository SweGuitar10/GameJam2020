using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public GameObject spawn;

    public float forwardSpeed = 25f;
    public float horizontalSpeed = 10f;
    public float stepSize = 5f;
    int xPos = 0;
    bool pressed;


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(horizontal, spawn.transform.position.y, spawn.transform.position.z).normalized;
        
        controller.Move(Vector3.forward  * forwardSpeed * Time.deltaTime); // Autoscroll


        Vector3 pos = gameObject.transform.position;
        if (horizontal < 0 || horizontal > 0)
        {
            if (!pressed)
            {
                changePosition(direction);
            }
            pressed = true;
        }
        else
        {
            pressed = false;
        }
        pos = new Vector3(xPos * stepSize, pos.y, pos.z);
        gameObject.transform.position = pos;

    }

    void changePosition(Vector3 direction)
    {
        if (direction.x > 0)
        {
            xPos++;
        }
        else
        {
            xPos--;
        }

        if (xPos > 1)
        {
            xPos = 1;
        }
        else if (xPos < -1)
        {
            xPos = -1;
        }
    }
}