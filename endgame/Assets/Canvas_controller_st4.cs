using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_controller_st4 : MonoBehaviour
{
    public GameObject arrow;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("father").GetComponent<new_son_controller>().CameraOutCheck())
        {
            arrow.SetActive(true);

        }
        else
        {
            arrow.SetActive(false);
        }
    }
}
