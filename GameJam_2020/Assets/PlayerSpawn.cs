using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public GameObject spawn;

    void Start()
    {
        gameObject.transform.position = spawn.transform.position;
    }
}
