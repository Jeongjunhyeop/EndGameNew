using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice_system : MonoBehaviour
{
    public GameObject father;
    public void Set_father_ready()
    {
        father.GetComponent<Father_Controller>().father_ready = false;
        father.GetComponent<Father_Controller>().FlipPlayer();
        gameObject.SetActive(false);
    }
}
