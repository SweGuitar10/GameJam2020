using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ButtonShape : MonoBehaviour
{
    public Button btn1, btn2, btn3;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            btn1.clicked += Btn1_clicked; ;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            btn2.clicked += Btn1_clicked; ;

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            btn3.clicked += Btn1_clicked; ;

        }
    }

    private void Btn1_clicked()
    {
        throw new System.NotImplementedException();
    }
}
