using UnityEngine;

public class Music_Manager : MonoBehaviour
{
    [Header("Audio Collection")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Effect")]
    public AudioClip background;
    public AudioClip OnClick;
    public AudioClip Choose;
    
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    // Update is called once per frame
    private void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
