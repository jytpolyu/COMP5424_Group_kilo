using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioConrtoler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource BgmAudio;
    [SerializeField] AudioSource SfxAudio;
    public AudioClip bgm;
    public AudioClip sfx;
    public AudioClip shoot;
    public AudioClip step;
    AudioConrtoler audiocontroller;
    void Start()
    {
        BgmAudio.clip = bgm;
        BgmAudio.Play();
        audiocontroller = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioConrtoler>();
    }
    public void Playsfx(AudioClip AC)
    {
        
        SfxAudio.PlayOneShot(AC);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audiocontroller.Playsfx(audiocontroller.sfx);
        }

    }
}
