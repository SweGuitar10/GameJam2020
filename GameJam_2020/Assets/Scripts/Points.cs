using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField]
    public static int points;

    public Text pointText;
    private void Awake()
    {
        points = 0;
    }

    private void Update()
    {
        pointText.text = "Will to live:"+ points;
    }

    
}
