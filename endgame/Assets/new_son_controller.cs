using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class new_son_controller : MonoBehaviour
{
    public Slider hpBar;

    Rigidbody2D rigid;
    Animator anim;

    public float runSpeed;  // 이동 속도
    float isRight = 1;  // 바라보는 방향 1 = 오른쪽 , -1 = 왼쪽

    float input_x;
    public float jumpPower = 1;

    public int Hp;
    public int Max_Hp;

    void Start()
    {
        Hp = 100;
        Max_Hp = 100;

        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        hpBar.value = (float)Hp / (float)Max_Hp;

        if (Hp <= 0)
            SceneManager.LoadScene("gameover");


        // 캐릭터 이동
        rigid.velocity = (new Vector2((1.0f) * runSpeed, rigid.velocity.y));
    }

    void FlipPlayer()
    {
        // 방향을 전환.
        transform.eulerAngles = new Vector3(0, Mathf.Abs(transform.eulerAngles.y - 180), 0);
        isRight = isRight * -1;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "monster")
        {
            Hp -= 10;
            anim.SetTrigger("hit");
        }

        if (col.tag == "item")
            Hp += 10;

        if (col.tag == "father_head")
            rigid.velocity = Vector2.up * jumpPower;

    }
}
