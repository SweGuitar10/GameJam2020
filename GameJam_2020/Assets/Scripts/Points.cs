using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int points;
    public TMP_Text pointText;
    //public Text pointText;
    private void Start()
    {
        points = 0;
    }

    private void Update()
    {
        pointText.text = "Points: "+ points;
    }

    
}
