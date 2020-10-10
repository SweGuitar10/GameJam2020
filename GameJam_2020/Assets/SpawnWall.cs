using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnWall", 4f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnWall()
    {
        Vector3 pos = gameObject.transform.position;
        GameObject newWall = Instantiate(wall);
        newWall.transform.position = new Vector3(0f, 3f, pos.z + 50f);
    }
}
