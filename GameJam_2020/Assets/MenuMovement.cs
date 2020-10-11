using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    int xPos = 0;
    bool pressed;
    
    public float stepSize = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        //Vector3 direction = new Vector3(horizontal, 0, 00).normalized;
        Vector3 pos = gameObject.transform.position;
        if (horizontal < 0 || horizontal > 0)
        {
            if (!pressed)
            {
                changePosition(pos);
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
