using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 playerPos;
  
    void Update()
    {
        followPlayer();
    }

    public void followPlayer()
    {
        playerPos = player.transform.position;
        gameObject.transform.position = new Vector3(0f, 7f, playerPos.z - 5f);
    }
}
