using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PauseControl : MonoBehaviour
{
    public static PauseControl instance;
    public EventTypes.VoidBoolDel pause;
    bool paused;
    bool gameOver;
   
    void Start()
    {
        SetTimeScale(1);
        if (instance != null && instance != this)
        {
            Destroy(instance);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    void Update()
    {
        if (gameOver)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            SetTimeScale(paused ? 1 : 0);
        }
        pause?.Invoke(paused);
    }

    public void Unpause()
    {
        paused = false;
        SetTimeScale(1);
        pause?.Invoke(paused);
    }

    public void GameOver()
    {
        gameOver = true;
    }
    // bool isPaused;
    // Put in PlayerInput's Update()
    // if (isPaused)
    // {
    //     return;
    // }
    // Put in PlayerInput's Start()
    //PauseControl.instance.pause += {val} => {isPaused = val};
}
