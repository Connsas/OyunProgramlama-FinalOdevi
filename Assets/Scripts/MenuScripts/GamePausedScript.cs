using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GamePausedScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        StopGame.isAudioListenerOn = true;
        SceneManager.UnloadSceneAsync("GamePausedScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("GameMainMenu");
    }

    public void Settings()
    {
        SceneManager.LoadScene("SettingsScene", LoadSceneMode.Additive);
    }
}
