using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public Transform[] pieces;
    public Vector3[] directions;
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 center = new Vector3(0f, 5f, 0f);
        pieces = new Transform[transform.childCount];
        directions = new Vector3[transform.childCount];
        
        for (int i = 0; i < transform.childCount; i++)
        {
            pieces[i] = transform.GetChild(i);
            Vector3 position = pieces[i].localPosition;
            position.x = 0;
            directions[i] = (position - center).normalized;
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i].localPosition += directions[i] * Time.deltaTime * speed;
        }
    }
}
