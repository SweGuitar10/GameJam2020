using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 playerPos;
  
    void Update()
    {
        if(player != null)
        {
            followPlayer();
        }
    }

    public void followPlayer()
    {
        playerPos = player.transform.position;
        gameObject.transform.position = new Vector3(0f, 8f, playerPos.z - 7f);
    }
}
