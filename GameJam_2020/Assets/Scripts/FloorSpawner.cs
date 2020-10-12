using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> floors;
    public GameObject floor;
    int listSize;
    Vector3 lastPos;

    void Start()
    {
        floors = new List<GameObject>();
        listSize = gameObject.transform.childCount;
        for(int i = 0; i < listSize; i++)
        {
            floors.Add(gameObject.transform.GetChild(i).gameObject);
        }
        lastPos = floors[gameObject.transform.childCount - 1].transform.position;


    }
    private void Update()
    {
        
    }
    public void spawnFloor()
    {
        GameObject newFloor = Instantiate(floor);
        newFloor.transform.position = new Vector3(lastPos.x, lastPos.y, lastPos.z + 73f);
        newFloor.transform.SetParent(gameObject.transform);
        floors.Add(newFloor);
        
        lastPos = floors[gameObject.transform.childCount - 1].transform.position;
        destroyFloor();
    }

    public void destroyFloor()
    {
        Destroy(floors[0]);
        floors.RemoveAt(0);
    }
}
