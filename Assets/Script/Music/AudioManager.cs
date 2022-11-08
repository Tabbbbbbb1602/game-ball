using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    //source từ tệp source
    public Sound[] sounds;
    public static AudioManager instance;

    private float MusicVolume;
    private float BackgroundVolume;

    private bool isMuteMusic;
    
    //slider
    public Slider volumeSliderMusic;
    public Slider VolumeSliderBackGround;

    //public Toggle toggleMusic;

    //âm thanh nền
    //public AudioSource backgroundAudio;

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
        /*BackgroundVolume = PlayerPrefs.GetFloat(PrefConst.SOUND);
        VolumeSliderBackGround.value = BackgroundVolume;*/
        if (PlayerPrefs.HasKey(PrefConst.MUSIC))
        {
            MusicVolume = PlayerPrefs.GetFloat(PrefConst.MUSIC);
            volumeSliderMusic.value = MusicVolume;
        }
        else
        {
            MusicVolume = 0.5f;
            volumeSliderMusic.value = MusicVolume;
        }


        if (PlayerPrefs.HasKey(PrefConst.MUTEMUSIC))
        {
            if(PlayerPrefs.GetFloat(PrefConst.MUTEMUSIC) == 1)
            {
                foreach (Sound s in sounds)
                {
                    s.source.mute = true;
                }
            }
            else
            {
                foreach (Sound s in sounds)
                {
                    s.source.mute = false;
                }
            }
        }
        else
        {
            foreach (Sound s in sounds)
            {
                s.source.mute = false;
            }
        }
    }

    private void Update()
    {
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
            PlayerPrefs.SetFloat(PrefConst.MUSIC, volume);
        }
    }

    //turn off and turn on music

    public void MusicON()
    {
        foreach (Sound s in sounds)
        {
            //s.source.mute = false;
            s.source.mute = false;
            PlayerPrefs.SetFloat(PrefConst.MUTEMUSIC, 0);
        }
        Debug.Log("False");
    }

    public void MuSicOff()
    {
        foreach (Sound s in sounds)
        {
            s.source.mute = true;
            PlayerPrefs.SetFloat(PrefConst.MUTEMUSIC, 1);
        }
        Debug.Log("true");
    }

    public void UpdateEffect(float volume)
    {
        //upload âm thanh theo volume
        //backgroundAudio.volume = BackgroundVolume;
        BackgroundVolume = volume;
    }

    //turn off and turn on sound
    public void EffectOn()
    {
        //backgroundAudio.mute = false;
        Debug.Log("EffectOn");
    }

    public void EffectOff()
    {
        //backgroundAudio.mute = true;
        Debug.Log("EffectOn");
    }
}
