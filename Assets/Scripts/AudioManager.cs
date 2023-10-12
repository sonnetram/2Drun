using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //单例
    public static AudioManager Instance;
    //播放组件
    private AudioSource player;
    void Start()
    {
        //单例
        Instance = this;
        //获取播放组件
        player = GetComponent<AudioSource>();

        
    }
    //不需要Update (逐帧）方法
    void Update()
    {
        
    }
    //播放音效
    public void Play(string name)
    {
        //通过名称获取音频片段   在Unity中的Resource文件中按name找到文件 然后以AudioClip格式加载
        AudioClip clip = Resources.Load<AudioClip>(name);
        //播放
        player.PlayOneShot(clip);
    }

}
