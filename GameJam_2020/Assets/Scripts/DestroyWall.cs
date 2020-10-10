using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    FloorSpawner flSpawn;
    public GameObject flr;
    private void Start()
    {
        flSpawn = flr.GetComponent<FloorSpawner>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("FloorDestroy"))
        {
            flSpawn.spawnFloor();
        }
    }
}
