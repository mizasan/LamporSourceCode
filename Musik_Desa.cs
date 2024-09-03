using UnityEngine;
using UnityEngine.SceneManagement;

public class Musik_Desa : MonoBehaviour
{
    public static Musik_Desa instance;

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

    private void Update()
    {
        // Cek apakah scene yang sedang dimuat adalah scene hutan
        if (SceneManager.GetActiveScene().name == "Hutan")
        {
            // Hentikan musik jika sedang dimainkan
            StopMusic();
        }
    }

    private void StopMusic()
    {
        // Hentikan audio source pada objek ini
        gameObject.GetComponent<AudioSource>().Stop();
    }
}

