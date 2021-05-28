using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_danger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "monster")
        {
            Destroy(col.gameObject);
        }
    }
}

