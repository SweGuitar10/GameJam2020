using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float forwardSpeed = 25f;
    public float horizontalSpeed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        controller.Move(Vector3.forward * forwardSpeed * Time.deltaTime);

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            controller.Move(direction * horizontalSpeed * Time.deltaTime);

        }
    }
}
