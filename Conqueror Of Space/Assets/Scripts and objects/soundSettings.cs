using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundSettings : MonoBehaviour
{
    public AudioMixerGroup music;
    public AudioMixerGroup effects;
    public AudioMixerGroup ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setVolumeMusic(float volume)
    {
        music.audioMixer.SetFloat("musicVolume", Mathf.Lerp(-80, 0, volume));
    }

    public void setVolumeEffects(float volume)
    {
        music.audioMixer.SetFloat("effectsVolume", Mathf.Lerp(-80, 0, volume));
        music.audioMixer.SetFloat("UIVolume", Mathf.Lerp(-80, 0, volume));
    }
}
