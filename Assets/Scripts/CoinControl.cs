using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    //�����������
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���ųԽ�ҵ�����
        AudioManager.Instance.Play("���");
        //�����Լ�����ң�
        Destroy(gameObject);

    }

  
}
