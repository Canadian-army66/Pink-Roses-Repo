using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PauseWorks : MonoBehaviour
{
    public bool paused;
    private float originalTimeScale;
    public Button backToGame;
    public GameObject settingsOff;
    public GameObject hudOn;

    public void Pause()
    {
        paused = true;

        originalTimeScale = Time.timeScale;
        Time.timeScale = 0f;
        settingsOff.SetActive(false);
        hudOn.SetActive(true);
    }

    public void notPaused()
    {
        paused = false;

        Time.timeScale = originalTimeScale;
        settingsOff.SetActive(true);
        hudOn.SetActive(false);
    }

    public void OnPause(InputValue button)
    {
        Pause();
        EventSystem.current.SetSelectedGameObject(backToGame.gameObject);
    }
}
