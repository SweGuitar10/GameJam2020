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

}
