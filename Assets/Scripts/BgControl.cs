using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgControl : MonoBehaviour

{
    //�ٶ�
    public float Speed = 0.2f;

   
    void Update()
    {
        //������Ѫ��Ϊ0
        if (PlayerControl.Hp == 0)
        {
            return;
        }
        //����������������
        foreach (Transform tran in transform)
        {
            //��ȡ�������λ��
            Vector3 pos = tran.position;
            //�����ٶ�������ƶ�
            pos.x -= Speed * Time.deltaTime;
            //�ж��Ƿ������Ļ
            if(pos.x < -7.2f)
            {
                pos.x += 7.2f * 2;
            }
            //λ�ø���������
            tran.position = pos;

        }
    }
}
