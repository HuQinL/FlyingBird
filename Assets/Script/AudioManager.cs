using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioClipType
{
    click,
    dead,
    score,
}


public class AudioManager : MonoBehaviour
{
    public AudioClip[] allAudioClips;
    public static AudioManager _instance;
    public AudioSource audioSourceBG;
    public AudioSource audioSourceOther;
    private void Awake()
    {
        _instance = this;
    }
    public void SetAudio(AudioClipType index)
    {
        if (GameServer.getSingleton().isAudio)
        {
            return;
        }
        audioSourceOther.clip = allAudioClips[(int)index];
        audioSourceOther.Play();
    }
    public void StopAudio()
    {
        audioSourceBG.Stop();
    }

    private void Update()
    {
        audioSourceBG.mute = GameServer.getSingleton().isAudio;
        audioSourceOther.mute = GameServer.getSingleton().isAudio;
    }
}
