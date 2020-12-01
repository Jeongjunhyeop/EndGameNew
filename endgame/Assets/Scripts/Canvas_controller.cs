using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_controller : MonoBehaviour
{
    public GameObject arrow;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("father").GetComponent<Father_Controller>().CameraOutCheck())
        {
            arrow.SetActive(true);

        }
        else
        {
            arrow.SetActive(false);
        }
    }
}
