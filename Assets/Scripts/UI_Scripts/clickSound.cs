using UnityEngine;


public class ClickSound : MonoBehaviour
{
    [SerializeField] AudioSource m_SoundSource;
    [SerializeField] AudioClip clickSound;
    private void Awake()
    {
        m_SoundSource = GetComponent<AudioSource>();
        m_SoundSource.clip = clickSound;
    }

    public void PlayClickSound()
    {
        m_SoundSource.PlayOneShot(m_SoundSource.clip);
    }

}
