using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{

    private static AudioManager instance;

    public AudioMixer masterMixer;

    public float soundLevel;


    public Slider MasterSlider, MusicSlider;
    public static AudioManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        masterMixer.SetFloat("MasterVol", PreferencesManager.GetMainVol());
        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVol());

        if (MasterSlider != null)
            PreferencesManager.GetMainVol();
        if (MusicSlider != null)
            PreferencesManager.GetMusicVol();

        masterMixer.SetFloat("MasterVol", PreferencesManager.GetMainVol());
        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVol());
    }
    public void ChaneMainVol(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMainVol(soundLevel);

        if (MasterSlider != null)
            PreferencesManager.GetMainVol();

        if (MusicSlider != null)
            PreferencesManager.GetMusicVol();
    }
    public void ChaneMusicVol(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVol(soundLevel);
    }

    public void ChangeSoundVol(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMainVol(soundLevel);
    }

    public void ChangeMusicVol(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVol(soundLevel);
    }
}
