using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_character : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "player" || col.tag == "father" || col.tag == "erase")
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
