using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class StopGame : MonoBehaviour
{

    public static bool isAudioListenerOn = true;
    public static float volume;
    public AudioListener AudioListener;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                isAudioListenerOn = false;
                AudioListener.pause = true;
                SceneManager.LoadScene("GamePausedScene", LoadSceneMode.Additive);
            }
        }

        if (isAudioListenerOn == true)
        {
            AudioListener.pause = false;
        }
    }
}
