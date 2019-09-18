using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class tranform : MonoBehaviour, IVirtualButtonEventHandler
{
    public int scale = 0;
    public int rotate = 0;
    public int translate = 0;
    public int xAxis = 0;
    public int yAxis = 0;
    public int zAxis = 0;
    public GameObject Cube;
    public Vector3 temp;

    public GameObject VBScale,VBRotate, VBTranslate, VBxAxis, VByAxis, VBzAxis, VBPositive, VBNegative;

    // Start is called before the first frame update
    void Start()
    {
        VBScale = GameObject.Find("Scale");
        VBScale.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBRotate = GameObject.Find("Rotate");
        VBRotate.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBTranslate = GameObject.Find("Translate");
        VBTranslate.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBxAxis = GameObject.Find("xAxis");
        VBxAxis.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VByAxis = GameObject.Find("yAxis");
        VByAxis.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBzAxis = GameObject.Find("zAxis");
        VBzAxis.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBPositive = GameObject.Find("Positive");
        VBPositive.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        VBNegative = GameObject.Find("Negative");
        VBNegative.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("button is pressed");



        if(vb.VirtualButtonName == "Scale")
        {
            scale = 1;
            rotate = 0;
            translate = 0;
            temp = Cube.transform.localScale;
            Debug.Log("scale is pressed");
        }
        if(scale == 1)
        {
            if (vb.VirtualButtonName == "xAxis")
            {
                xAxis = 1;
                yAxis = 0;
                zAxis = 0;
                Debug.Log("x Axis is pressed");
            }

            if (xAxis == 1 && vb.VirtualButtonName == "Positive")
            {
                temp.x = temp.x + 0.3f;
                Cube.transform.localScale = temp;
                Debug.Log("positive is pressed");
            }else if (xAxis == 1 && vb.VirtualButtonName == "Negative")
            {
                temp.x = temp.x - 0.3f;
                Cube.transform.localScale = temp;
                Debug.Log("negative is pressed");
            }
        }





        if (vb.VirtualButtonName == "Rotate")
        {
            scale = 0;
            rotate = 1;
            translate = 0;
            temp = Cube.transform.localScale;
            Debug.Log("rotate is pressed");
        }
        if (rotate == 1)
        {
            if (vb.VirtualButtonName == "xAxis")
            {
                xAxis = 1;
                yAxis = 0;
                zAxis = 0;
                Debug.Log("x Axis is pressed");
            }
            else if(vb.VirtualButtonName == "zAxis")
            {
                xAxis = 0;
                yAxis = 0;
                zAxis = 1;
            }

            if (xAxis == 1 && vb.VirtualButtonName == "Positive")
            {
                Cube.transform.Rotate(0, 0, 90); ;
                Debug.Log("positive is pressed");
            }
            else if (xAxis == 1 && vb.VirtualButtonName == "Negative")
            {
                Cube.transform.Rotate(0, 0, -90);
                Debug.Log("negative is pressed");
            }



        }





        if (vb.VirtualButtonName == "Translate")
        {
            scale = 0;
            rotate = 0;
            translate = 1;
            temp = Cube.transform.localScale;
            Debug.Log("translate is pressed");
        }
        if (translate == 1)
        {
            if (vb.VirtualButtonName == "xAxis")
            {
                xAxis = 1;
                yAxis = 0;
                zAxis = 0;
                Debug.Log("x Axis is pressed");
            }

            if (xAxis == 1 && vb.VirtualButtonName == "Positive")
            {
                //temp.x = temp.x + 90;
                Cube.transform.Translate(0, 0, Time.deltaTime);
                Debug.Log("positive is pressed");
            }
            else if (xAxis == 1 && vb.VirtualButtonName == "Negative")
            {
                //temp.x = temp.x - 90;
                Cube.transform.Translate(0, 0, -Time.deltaTime);
                Debug.Log("negative is pressed");
            }

            if (vb.VirtualButtonName == "yAxis")
            {
                xAxis = 0;
                yAxis = 1;
                zAxis = 0;
                Debug.Log("y Axis is pressed");
            }

            if (yAxis == 1 && vb.VirtualButtonName == "Positive")
            {
                Cube.transform.Translate(0, Time.deltaTime, 0);
                Debug.Log("positive is pressed");
            }
            else if (yAxis == 1 && vb.VirtualButtonName == "Negative")
            {
                Cube.transform.Translate(0, -Time.deltaTime, 0);
                Debug.Log("negative is pressed");
            }
        }


    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
    }





}
