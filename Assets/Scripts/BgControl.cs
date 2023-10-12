using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour

{
    //速度
    public float Speed = 0.2f;

   
    void Update()
    {
        //如果玩家血量为0
        if (PlayerControl.Hp == 0)
        {
            return;
        }
        //遍历背景，子物体
        foreach (Transform tran in transform)
        {
            //获取子物体的位置
            Vector3 pos = tran.position;
            //按照速度向左侧移动
            pos.x -= Speed * Time.deltaTime;
            //判断是否出了屏幕
            if(pos.x < -7.2f)
            {
                pos.x += 7.2f * 2;
            }
            //位置赋给子物体
            tran.position = pos;

        }
    }
}
