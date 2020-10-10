using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("FloorDestroy"))
        {
            FloorDestroyer.destroyFloor();
        }
    }
}
