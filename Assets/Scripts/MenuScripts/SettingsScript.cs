using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{

    public AudioMixer AudioMixer;
    private Resolution[] Resolutions;
    public TMP_Dropdown ResolutionDropdown;
    public TMP_Dropdown GraphicSettingsDropdown;
    public Slider VolumeSlider;
    public Toggle IsFullScreen;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Resolutions = Screen.resolutions;
        List<string> resolutionStrings = new List<string>();

        int resolutionIndex = 0;
        for (int i = 0; i < Resolutions.Length; i++)
        {
            string option = Resolutions[i].ToString();
            resolutionStrings.Add(option);

            if (Resolutions[i].height == Screen.currentResolution.height && Resolutions[i].width == Screen.currentResolution.width && Resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {
                resolutionIndex = i;
            }
        }

        ResolutionDropdown.ClearOptions();
        ResolutionDropdown.AddOptions(resolutionStrings);
        ResolutionDropdown.value = resolutionIndex;
        ResolutionDropdown.RefreshShownValue();
        GraphicSettingsDropdown.value = QualitySettings.GetQualityLevel();
        AudioMixer.GetFloat("volume", out float volume);
        VolumeSlider.value = volume;
        IsFullScreen.isOn = Screen.fullScreen;
    }

    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = Resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen, resolution.refreshRate);
    }

    public void Back()
    {
        SceneManager.UnloadSceneAsync("SettingsScene");
    }
}
