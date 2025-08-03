using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action PlayClickSound;
    AudioManager audioManager;


    public void TriggerClickEvent()
    {
        PlayClickSound?.Invoke();
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        PlayClickSound += GameManager_PlayClickSound;
    }

    private void GameManager_PlayClickSound()
    {
        audioManager.ClickSoundPlayer();
    }
}
