using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    //速度
    public float Speed = 2f;
    //要随机的地面数组
    public GameObject[] GroundPrefabs;



    void Update()
    {
        //如果玩家血量为0
        if(PlayerControl.Hp == 0)
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
            if (pos.x < -7.2f)
            {
                //创建新的地面 从数组里面随机拿到一个预设体，将其添加到GroundControl（父）上,并且拿到这个组件
                Transform newTrans = Instantiate(GroundPrefabs[Random.Range(0, GroundPrefabs.Length)], transform).transform;
                //获取新地面的位置
                Vector2 newPos = newTrans.position;
                //设置新地面的位置
                newPos.x = pos.x + 7.2f * 2;
                //将位置给新地面
                newTrans.position = newPos;

                //销毁左边出了屏幕的地面
                Destroy(tran.gameObject);
            }
            //位置赋给子物体
            tran.position = pos;

        }
    }
}
