using UnityEngine;
using UnityEngine.SceneManagement;

public class Musik_Menu : MonoBehaviour
{
    public static Musik_Menu instance; // Singleton instance
    public AudioSource mainMenuMusic; // Drag your AudioSource here in the Inspector

    private void Awake()
    {
        // Check if there is already an instance of Musik_Menu
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object persistent between scenes
        }
        else
        {
            // Destroy this instance if it's not the Singleton instance
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to the sceneLoaded event
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe from the sceneLoaded event
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.StartsWith("Desa"))
        {
            if (mainMenuMusic.isPlaying)
            {
                mainMenuMusic.Stop();
            }
        }
        else if (scene.name == "MainMenu")
        {
            if (!mainMenuMusic.isPlaying)
            {
                mainMenuMusic.Play();
            }
        }
        else if (scene.name == "Tutorial")
        {
            if (mainMenuMusic.isPlaying)
            {
                mainMenuMusic.Stop();
                mainMenuMusic.Play(); // Restart the music for the tutorial scene
            }
        }
    }
}
