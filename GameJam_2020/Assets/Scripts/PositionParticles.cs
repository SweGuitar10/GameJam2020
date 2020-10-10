using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionParticles : MonoBehaviour
{
    public GameObject player;
    float zOffset = 10f;
    float yOffset = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.gameObject.transform.position;
        gameObject.transform.position = new Vector3(0f, playerPos.y + yOffset, playerPos.z + zOffset);
    }
}
