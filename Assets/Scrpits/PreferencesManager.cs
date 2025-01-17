using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PreferencesManager
{
    public static float GetMusicVol()
    {
        return PlayerPrefs.GetFloat("MusicVolume", 1);
    }
    public static float GetMainVol()
    {
        return PlayerPrefs.GetFloat("MasterVolume", 1);
    }

    public static void SetMusicVol(float soundLevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }
    public static void SetMainVol(float soundLevel)
    {
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }
}
