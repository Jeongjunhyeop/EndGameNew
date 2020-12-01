using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_arrow : MonoBehaviour
{
    public int arrow_speed;

    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = Vector2.left * arrow_speed;
    }
}
