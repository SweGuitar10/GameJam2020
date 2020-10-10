using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject plane;
    public GameObject spawn;
    private void Awake()
    {
        //GameObject previousPlane = Instantiate(plane);
        //previousPlane.transform.position = spawn.transform.position;
        //spawnPlane(plane);
    }

    private void Update()
    {
       // InvokeRepeating("spawnPlane", 3f, 1f);
    }


    void spawnPlane(GameObject previousPlane)
    {
        GameObject newPlane = Instantiate(plane);
        Vector3 pos = Vector3.zero;
        if(previousPlane == null)
        {
            Instantiate(plane);
            pos = previousPlane.transform.position;
        }

        Vector3 newPlanePos = new Vector3(pos.x, pos.y, pos.z + 100);
        newPlane.transform.position = newPlanePos;

    }


}
