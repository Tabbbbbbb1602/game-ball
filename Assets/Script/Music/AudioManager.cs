using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    //source từ tệp source
    public Sound[] sounds;
    public static AudioManager instance;

    private float MusicVolume = 0.5f;
    private float BackgroundVolume = 0.5f;
    
    //slider
    public Slider volumeSliderMusic;
    public Slider VolumeSliderBackGround;

    //âm thanh nền
    public AudioSource backgroundAudio;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.mute = s.mute;
        }
        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        //lấy âm thanh nếu chưa có thì khởi tạo, có rồi thì lấy ra
        MusicVolume = PlayerPrefs.GetFloat(PrefConst.MUSIC);
        volumeSliderMusic.value = MusicVolume;
        BackgroundVolume = PlayerPrefs.GetFloat(PrefConst.SOUND);
        VolumeSliderBackGround.value = BackgroundVolume;
    }

    private void Update()
    {
        //save âm thanh
        PlayerPrefs.SetFloat(PrefConst.MUSIC, MusicVolume);
        PlayerPrefs.SetFloat(PrefConst.SOUND, BackgroundVolume);
    }

    public void Play(string name)
    {
        //Play âm thanh theo tên
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) return;
        s.source.Play();
    }

    public void UpdateVolumeMusic(float volume)
    {
        //upload âm thanh theo volume
        gameObject.GetComponent<AudioSource>().volume = MusicVolume;

        MusicVolume = volume;

        foreach (Sound s in sounds)
        {
            s.source.volume = volume;
        }
    }

    //turn off and turn on music

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
        //upload âm thanh theo volume
        backgroundAudio.volume = BackgroundVolume;
        BackgroundVolume = volume;
        PlayerPrefs.Save();
    }

    //turn off and turn on sound
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
