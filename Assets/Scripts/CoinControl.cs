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
    //如果产生触发
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //播放吃金币的声音
        AudioManager.Instance.Play("金币");
        //销毁自己（金币）
        Destroy(gameObject);

    }

  
}
