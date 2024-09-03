using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Mba Yuli Scene
public class UIManager_3 : MonoBehaviour
{
    public GameObject storyCanvas;
    public Button skipButton;
    public Button continueButton;

    private void Start_3()
    {
        // Mengaktifkan fungsi tombol "Skip"
        skipButton.onClick.AddListener(SkipStory_3);

        // Mengaktifkan fungsi tombol "Lanjutkan"
        continueButton.onClick.AddListener(ContinueStory_3);

        // Menonaktifkan UI Canvas cerita secara default
        storyCanvas.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipStory_3();
        }

        // Mengaktifkan tombol "Lanjutkan" dengan tombol keyboard (misalnya tombol "C")
        if (Input.GetKeyDown(KeyCode.C))
        {
            ContinueStory_3();
        }
    }

    private void SkipStory_3()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Sawah2");

        // Implementasikan logika skip cerita di sini
    }

    private void ContinueStory_3()
    {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Jika index scene sudah mencapai batas tertentu (misalnya index scene ke-4), kembali ke SampleScene
    if (currentSceneIndex == 22)
    {
        SceneManager.LoadScene("Sawah2");
    }
    else
    {
        // Jika belum mencapai batas, lanjut ke scene berikutnya
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
}