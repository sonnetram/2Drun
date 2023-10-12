using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    //�ٶ�
    public float Speed = 2f;
    //Ҫ����ĵ�������
    public GameObject[] GroundPrefabs;



    void Update()
    {
        //������Ѫ��Ϊ0
        if(PlayerControl.Hp == 0)
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
            if (pos.x < -7.2f)
            {
                //�����µĵ��� ��������������õ�һ��Ԥ���壬������ӵ�GroundControl��������,�����õ�������
                Transform newTrans = Instantiate(GroundPrefabs[Random.Range(0, GroundPrefabs.Length)], transform).transform;
                //��ȡ�µ����λ��
                Vector2 newPos = newTrans.position;
                //�����µ����λ��
                newPos.x = pos.x + 7.2f * 2;
                //��λ�ø��µ���
                newTrans.position = newPos;

                //������߳�����Ļ�ĵ���
                Destroy(tran.gameObject);
            }
            //λ�ø���������
            tran.position = pos;

        }
    }
}
