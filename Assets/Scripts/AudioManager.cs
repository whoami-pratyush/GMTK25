using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip BGM;
    public AudioClip clickSFX;

    public static AudioManager instance;

    private GameManager gameManager;



    private void Awake()
    {
        //GameObject gmObject = GameObject.FindGameObjectWithTag("GameManager");

        //if (gmObject != null)
        //{
        //    gameManager = gmObject.GetComponent<GameManager>();

        //    if (gameManager != null)
        //    {
        //        gameManager.PlayClickSound += GameManager_PlayClickSound;
        //    }
        //    else
        //    {
        //        Debug.LogError("GameManager script not found on tagged GameObject.");
        //    }
        //}
        //else
        //{
        //    Debug.LogError("GameObject with tag 'GameManager' not found.");
        //}
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        //gameManager.PlayClickSound += GameManager_PlayClickSound;

    }

    //private void GameManager_PlayClickSound()
    //{
    //    ClickSoundPlayer();
    //}

    private void Start()
    {
        musicSource.clip = BGM;
        musicSource.Play();
    }

    public void ClickSoundPlayer()
    {

        sfxSource.clip = clickSFX;
        sfxSource.PlayOneShot(sfxSource.clip);
    }
}
