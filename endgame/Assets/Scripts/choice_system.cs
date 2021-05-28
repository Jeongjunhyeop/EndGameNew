using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice_system : MonoBehaviour
{
    public GameObject father;

    public GameObject st2_say1_box;

    public void Set_father_ready()
    {
        father.GetComponent<Father_Controller>().father_ready = false;
        father.GetComponent<Father_Controller>().FlipPlayer();
        gameObject.SetActive(false);
    }

    public void Set_father_away()
    {
        father.GetComponent<ChatBox>().Talk_sry();
        father.GetComponent<Father_Controller>().father_ready = false;
        father.GetComponent<Father_Controller>().FlipPlayer();
        st2_say1_box.SetActive(false);
    }

    public void delete_answer()
    {
        st2_say1_box.SetActive(false);
    }
}
