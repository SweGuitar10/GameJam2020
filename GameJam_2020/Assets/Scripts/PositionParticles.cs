using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionParticles : MonoBehaviour
{
    public GameObject player;
    float zOffset = 10f;
    float yOffset = 5f; 
 

    void Update()
    {
        if(player != null)
        {
            Vector3 playerPos = player.gameObject.transform.position;
            gameObject.transform.position = new Vector3(0f, playerPos.y + yOffset, playerPos.z + zOffset);
        }
    }
}
