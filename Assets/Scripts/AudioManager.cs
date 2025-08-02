using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip BGM;
    public AudioClip clickSFX;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        musicSource.clip = BGM;
        musicSource.Play();
    }

    public void ClickSoundPlayer()
    {
        sfxSource.PlayOneShot(clickSFX);
    }
}
