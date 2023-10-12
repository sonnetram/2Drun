using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //血量
    public static int Hp = 1;
    //刚体组件
    private Rigidbody2D rbody;
    //动画组件
    private Animator ani;
    //当前是否碰到了地面
    private bool isGround;

    void Start()
    {
        //获取刚体组件
        rbody = GetComponent<Rigidbody2D>();
        //获取动画组件
        ani = GetComponent<Animator>();
        
    }

    void Update()
    {
        //如果按了空格键
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //跳跃
            Jump();
        }
    }
    //跳跃
    public void Jump()
    {
        //如果在地面上才能跳跃
        if(isGround == true)
        {
            //给刚体一个向上的力
            rbody.AddForce(Vector2.up * 400);
            //播放跳跃声音
            AudioManager.Instance.Play("跳");
        }
        
    }

    //发生碰撞
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //判断如果是地面
        if(collision.collider.tag == "Ground")
        {
            isGround = true;
            //结束跳跃
            ani.SetBool("isJump", false);
        }
        //如果碰到死亡边界
        if (collision.collider.tag == "Die" && Hp > 0)
        {
            //血量为0
            Hp = 0;
            //播放死亡声音
            AudioManager.Instance.Play("Boss死了");
            //播放死亡动画
            ani.SetBool("isDie", true); 


        }
    }
    //结束碰撞
    private void OnCollisionExit2D(Collision2D collision)
    {
        //判断如果是空中
        if (collision.collider.tag == "Ground")
        {
            isGround = false;
            //开始跳跃
            ani.SetBool("isJump", true);
        }
    }

}
