using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    public float speed = 1.4f;
    public GameObject player;
    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 pos = new Vector3(0f, 0f, -player.transform.position.z);
        gameObject.transform.Translate(pos * Time.deltaTime * speed);

    }
}
