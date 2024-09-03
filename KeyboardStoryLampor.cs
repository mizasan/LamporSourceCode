using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Bu Broto Scene
public class Jumpscare_Lampor_Scene : MonoBehaviour
{
    public GameObject storyCanvas;
    public Button skipButton;
    private void Start_Lampor()
    {
        // Mengaktifkan fungsi tombol "Skip"
        skipButton.onClick.AddListener(SkipStory_Lampor);

        // Menonaktifkan UI Canvas cerita secara default
        storyCanvas.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipStory_Lampor();
        }
    }
    private void SkipStory_Lampor()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Hutan");

        // Implementasikan logika skip cerita di sini
    }
}