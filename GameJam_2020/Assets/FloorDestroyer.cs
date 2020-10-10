using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour
{
    public static GameObject floor;
    public GameObject newFloor;
    public static void destroyFloor()
    {
        
        floor = GameObject.Find("Floor");
        Destroy(floor);

    }

    public void spawnFloor()
    {
        Vector3 pos = floor.transform.position;
        GameObject floor2 = Instantiate(newFloor);
        floor2.transform.position = new Vector3(pos.x, pos.y, pos.z + 70f);

    }
}
