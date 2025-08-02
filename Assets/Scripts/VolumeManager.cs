using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class VolumeManager : MonoBehaviour
{
    private string targetScene = "SettingsScene";
    public AudioMixer audioMixer;
    private Slider musicSlider;
    private Slider sfxSlider;

    private void Start()
    {
        if (PlayerPrefs.GetFloat("MusicVolume") != null)
        {
            audioMixer.SetFloat("Music", Mathf.Log10(PlayerPrefs.GetFloat("MusicVolume")) * 20f);
        }
        if (PlayerPrefs.GetFloat("SFXVolume") != null)
        {
            audioMixer.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("SFXVolume")) * 20f);
        }
    }

    private void OnEnable()
    {
        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
    }
    private void OnDisable()
    {
        SceneManager.activeSceneChanged -= SceneManager_activeSceneChanged;
    }

    private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
    {
        if (SceneManager.GetActiveScene().name == targetScene)
        {
            musicSlider = GameObject.FindGameObjectWithTag("MusicSlider").GetComponent<Slider>();
            sfxSlider = GameObject.FindGameObjectWithTag("SFXSlider").GetComponent<Slider>();
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
            sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
            musicSlider.onValueChanged.AddListener((float musicVolume) =>
            {
                //float volume = Mathf.Log10(musicVolume) * 20f;
                audioMixer.SetFloat("Music", Mathf.Log10(musicVolume) * 20f);
                PlayerPrefs.SetFloat("MusicVolume", musicVolume);
            });
            sfxSlider.onValueChanged.AddListener((float sfxVolume) =>
            {
                //float volume = Mathf.Log10(sfxVolume) * 20f;
                audioMixer.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20f);
                PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
            });

        }
    }
}

