using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public float points;

    public Text pointText;
    private void Start()
    {
        points = 0;
    }

    private void Update()
    {
        pointText.text = "Points: "+ (int)points;
    }

    
}
