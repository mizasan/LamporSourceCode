using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    public AudioClip footstepSound; // AudioClip untuk suara langkah
    public float footstepInterval = 0.5f; // Interval antara suara langkah

    private AudioSource audioSource;
    private float nextFootstepTime;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = footstepSound;
        nextFootstepTime = 0f;
    }

    private void Update()
    {
        if (Time.time > nextFootstepTime && Input.GetAxis("Vertical") != 0f)
        {
            audioSource.Play();
            nextFootstepTime = Time.time + footstepInterval;
        }
    }
}
