using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{

    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("This is collision");
        Debug.Log(hit.gameObject.tag);
    }
    
}
