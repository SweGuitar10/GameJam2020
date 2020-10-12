using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0.0f, 0.2f, 0.0f, Space.Self);
    }
}
