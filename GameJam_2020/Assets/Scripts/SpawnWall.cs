using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;
    public GameObject fakeWall;
    public List<GameObject> shapeWalls;
    public float spawnDist = 100f;
    float wallHeight = 2.5f;

    public void spawnFakeWall()
    {
        int shapePos = (int)Random.Range(0f, 3f);

        GameObject wallFake1 = Instantiate(fakeWall);
        GameObject wallFake2 = Instantiate(fakeWall);
        float z = gameObject.transform.position.z + spawnDist;

        Vector3 wall1 = new Vector3(-5f, wallHeight, z);
        Vector3 wall2 = new Vector3(0f, wallHeight, z);
        Vector3 wall3 = new Vector3(5f, wallHeight, z);

        switch (shapePos)
        {
            case 0:
                wallFake1.transform.position = wall2;
                wallFake2.transform.position = wall3;
                break;
            case 1:
                wallFake1.transform.position = wall1;
                wallFake2.transform.position = wall3;
                break;
            case 2:
                wallFake1.transform.position = wall2;
                wallFake2.transform.position = wall1;
                break;
        }
    }

    public void spawnShapeWall()
    {
        int shapeIndex = (int)Random.Range(0f, 3f);
        int shapePos = (int)Random.Range(0f, 3f);

        GameObject wallShape = Instantiate(shapeWalls[shapeIndex]);
        GameObject wallFake1 = Instantiate(fakeWall);
        GameObject wallFake2 = Instantiate(fakeWall);

        wallShape.transform.SetParent(GameObject.Find("WallParent").transform);
        wallFake1.transform.SetParent(GameObject.Find("WallParent").transform);
        wallFake2.transform.SetParent(GameObject.Find("WallParent").transform);


        float z = gameObject.transform.position.z + spawnDist;
        Vector3 wall1 = new Vector3(-5f, wallHeight, z);
        Vector3 wall2 = new Vector3(0f, wallHeight, z);
        Vector3 wall3 = new Vector3(5f, wallHeight, z);

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
