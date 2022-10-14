using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    private float MusicVolume = 0.5f;
    private float BackgroundVolume = 0.5f;
    public Slider volumeSliderMusic;
    public Slider VolumeSliderBackGround;

    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;

    private bool isMusic;
    private bool isEffect;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.mute = s.mute;
        }

    }


    private void Start()
    {
        MusicVolume = PlayerPrefs.GetFloat(PrefConst.MUSIC);
        volumeSliderMusic.value = MusicVolume;
        BackgroundVolume = PlayerPrefs.GetFloat(PrefConst.SOUND);
        VolumeSliderBackGround.value = BackgroundVolume;
    }

    private void Update()
    {
        PlayerPrefs.SetFloat(PrefConst.MUSIC, MusicVolume);
        PlayerPrefs.SetFloat(PrefConst.SOUND, BackgroundVolume);
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) return;
        s.source.Play();
    }

    public void UpdateVolumeMusic(float volume)
    {
        gameObject.GetComponent<AudioSource>().volume = MusicVolume;

        MusicVolume = volume;

        foreach (Sound s in sounds)
        {
            s.source.volume = volume;
        }
    }

    public void MusicON()
    {
        foreach (Sound s in sounds)
        {
            s.source.mute = false;
        }
        PlayerPrefs.Save();
    }

    public void MuSicOff()
    {
        foreach (Sound s in sounds)
        {
            s.source.mute = true;
        }
        PlayerPrefs.Save();
    }

    public void UpdateEffect(float volume)
    {
        backgroundAudio.volume = BackgroundVolume;
        BackgroundVolume = volume;
        PlayerPrefs.Save();
    }

    public void EffectOn()
    {
        backgroundAudio.mute = false;
        PlayerPrefs.Save();
    }

    public void EffectOff()
    {
        backgroundAudio.mute = true;
        PlayerPrefs.Save();
        
    }
}
