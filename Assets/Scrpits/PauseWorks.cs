using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseWorks : MonoBehaviour
{
    public bool paused;
    private float originalTimeScale;

    public void Pause()
    {
        paused = true;

        originalTimeScale = Time.timeScale;
        Time.timeScale = 0f;
    }

    public void notPaused()
    {
        paused = false;

        Time.timeScale = originalTimeScale;
    }

}
