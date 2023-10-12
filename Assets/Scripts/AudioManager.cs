using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //����
    public static AudioManager Instance;
    //�������
    private AudioSource player;
    void Start()
    {
        //����
        Instance = this;
        //��ȡ�������
        player = GetComponent<AudioSource>();

        
    }
    //����ҪUpdate (��֡������
    void Update()
    {
        
    }
    //������Ч
    public void Play(string name)
    {
        //ͨ�����ƻ�ȡ��ƵƬ��   ��Unity�е�Resource�ļ��а�name�ҵ��ļ� Ȼ����AudioClip��ʽ����
        AudioClip clip = Resources.Load<AudioClip>(name);
        //����
        player.PlayOneShot(clip);
    }

}
