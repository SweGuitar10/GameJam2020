using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int points;

    public Text pointText;
    private void Awake()
    {
        points = 0;
    }

    private void Update()
    {
        pointText.text = "Points: "+ points;
    }

    
}
