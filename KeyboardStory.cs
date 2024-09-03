using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Mas Yanto Scene
public class UIManager : MonoBehaviour
{
    public GameObject storyCanvas;
    public Button skipButton;
    public Button continueButton;

    private void Start()
    {
        // Mengaktifkan fungsi tombol "Skip"
        skipButton.onClick.AddListener(SkipStory);

        // Mengaktifkan fungsi tombol "Lanjutkan"
        continueButton.onClick.AddListener(ContinueStory);

        // Menonaktifkan UI Canvas cerita secara default
        storyCanvas.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipStory();
        }

        // Mengaktifkan tombol "Lanjutkan" dengan tombol keyboard (misalnya tombol "C")
        if (Input.GetKeyDown(KeyCode.C))
        {
            ContinueStory();
        }
    }

    private void SkipStory()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Desa2");

        // Implementasikan logika skip cerita di sini
    }

    private void ContinueStory()
    {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Jika index scene sudah mencapai batas tertentu (misalnya index scene ke-4), kembali ke SampleScene
    if (currentSceneIndex == 16)
    {
        SceneManager.LoadScene("Desa2");
    }
    else
    {
        // Jika belum mencapai batas, lanjut ke scene berikutnya
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
}