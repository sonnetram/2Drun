using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Ѫ��
    public static int Hp = 1;
    //�������
    private Rigidbody2D rbody;
    //�������
    private Animator ani;
    //��ǰ�Ƿ������˵���
    private bool isGround;

    void Start()
    {
        //��ȡ�������
        rbody = GetComponent<Rigidbody2D>();
        //��ȡ�������
        ani = GetComponent<Animator>();
        
    }

    void Update()
    {
        //������˿ո��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //��Ծ
            Jump();
        }
    }
    //��Ծ
    public void Jump()
    {
        //����ڵ����ϲ�����Ծ
        if(isGround == true)
        {
            //������һ�����ϵ���
            rbody.AddForce(Vector2.up * 400);
            //������Ծ����
            AudioManager.Instance.Play("��");
        }
        
    }

    //������ײ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�ж�����ǵ���
        if(collision.collider.tag == "Ground")
        {
            isGround = true;
            //������Ծ
            ani.SetBool("isJump", false);
        }
        //������������߽�
        if (collision.collider.tag == "Die" && Hp > 0)
        {
            //Ѫ��Ϊ0
            Hp = 0;
            //������������
            AudioManager.Instance.Play("Boss����");
            //������������
            ani.SetBool("isDie", true); 


        }
    }
    //������ײ
    private void OnCollisionExit2D(Collision2D collision)
    {
        //�ж�����ǿ���
        if (collision.collider.tag == "Ground")
        {
            isGround = false;
            //��ʼ��Ծ
            ani.SetBool("isJump", true);
        }
    }

}
