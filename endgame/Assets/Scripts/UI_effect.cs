using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_effect : MonoBehaviour
{
    public void soundeffect_walk()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
