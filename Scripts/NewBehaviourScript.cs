using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource footstepAudioSource;   // 用于播放脚步声的 AudioSource
    public AudioClip[] footstepClips;         // 存放不同的脚步声音效
    public float stepInterval = 0.5f;         // 两次脚步声之间的间隔
    private float stepTimer = 0f;
    AudioConrtoler audiocontroller;
    // Start is called before the first frame update
    void Start()
    {
        audiocontroller = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioConrtoler>();

    }

    // Update is called once per frame
    void Update()
    {
        // 监听WASD按键
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            // 计时器计算间隔
            stepTimer += Time.deltaTime;

            // 当计时器超过步伐间隔时，播放脚步声
            if (stepTimer >= stepInterval)
            {
                PlayFootstep();
                stepTimer = 0f;  // 重置计时器
            }
        }
        else
        {
            // 没有按下移动键时重置计时器
            stepTimer = 0f;
        }
    }

    // 播放随机的脚步声
    void PlayFootstep()
    {
  
            // 随机选择一个脚步音效
            audiocontroller.Playsfx(audiocontroller.step);

    }
}
