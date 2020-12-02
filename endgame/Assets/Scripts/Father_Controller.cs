using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Father_Controller : MonoBehaviour
{
    public float runSpeed;  // 이동 속도
    public float jumpPower;

    Rigidbody2D rigid;
    Animator anim;
    public GameObject son;

   public bool father_ready;
    // Start is called before the first frame update
    void Start()
    {
        runSpeed = 1;
        father_ready = false;

        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (father_ready == true && (son.transform.position.x > gameObject.transform.position.x))
            father_ready = false;

        if (father_ready)
        {
            anim.SetBool("father_ready",true);
            runSpeed = 0;
        }
        else
        {
            anim.SetBool("father_ready", false);
            runSpeed = 1;
        }

        rigid.velocity = (new Vector2((1.0f) * runSpeed, rigid.velocity.y));
        //CameraOutCheck();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "wall")
        {
            rigid.velocity = Vector2.up * jumpPower;
        }

        if (col.tag == "son_wait_pos")
        {
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk_danger();
            Destroy(col);
        }

        if (col.tag == "apple")
        {
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk_apple();
            Destroy(col);
        }

        if (col.tag == "wait0")
        {
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk();
            Destroy(col);
        }

        if (col.tag == "wait2")
        {
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk_platform();
            Destroy(col);
        }

        if (col.tag == "wait3")
        {
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk_bird();
            Destroy(col);
        }
    }   

    public bool CameraOutCheck()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(gameObject.transform.position);
 
        if (pos.x <= -0.025f)
        {
            Debug.Log("OUT!!");
            return true;
        }
        else if (pos.x >= 1.025f)
        {
            pos.x = 1;
            Debug.Log("OUT!!");
            return true;
        }
        else if (pos.y <= -0.025f)
        {
            Debug.Log("OUT!!");
            return true;
        }
        else if (pos.y >= 1.025f)
        {
            Debug.Log("OUT!!");
            return true;
        }

        return false;
    }

}
