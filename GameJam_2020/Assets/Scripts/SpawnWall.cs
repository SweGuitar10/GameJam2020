using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;
    public GameObject fakeWall;
    public List<GameObject> shapeWalls;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnWall", 1f, 2f);
    }

 

    void spawnWall()
    {
        int shapeIndex = (int)Random.Range(0f, 3f);
        int shapePos = (int)Random.Range(0f, 3f);

        GameObject wallShape = Instantiate(shapeWalls[shapeIndex]);
        GameObject wallFake1 = Instantiate(fakeWall);
        GameObject wallFake2 = Instantiate(fakeWall);

        float z = gameObject.transform.position.z + 50f;
        Vector3 wall1 = new Vector3(-5f, 3f, z);
        Vector3 wall2 = new Vector3(0f, 3f, z);
        Vector3 wall3 = new Vector3(5f, 3f, z);

        

        switch(shapePos)
        {
            case 0:
                wallShape.transform.position = wall1;
                wallFake1.transform.position = wall2;
                wallFake2.transform.position = wall3;
                break;
            case 1:
                wallShape.transform.position = wall2;
                wallFake1.transform.position = wall1;
                wallFake2.transform.position = wall3;
                break;
            case 2:
                wallShape.transform.position = wall3;
                wallFake1.transform.position = wall2;
                wallFake2.transform.position = wall1;
                break;


        }


    }
}
