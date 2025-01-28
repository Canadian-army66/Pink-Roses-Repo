using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{

    public Slider musicSlider;
    public Slider masterSlider;

    void Start()
    {
        if (masterSlider != null && masterSlider.gameObject.activeInHierarchy)
        {
            masterSlider.value = PreferencesManager.GetMainVol();
        }

        if (musicSlider != null && musicSlider.gameObject.activeInHierarchy)
        {
            musicSlider.value = PreferencesManager.GetMusicVol();
        }
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.ChangeSoundVol(soundLevel);
        }
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.ChangeMusicVol(soundLevel);
        }
    }
}
