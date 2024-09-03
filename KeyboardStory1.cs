using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Bu Broto Scene
public class UIManager_2 : MonoBehaviour
{
    public GameObject storyCanvas;
    public Button skipButton;
    public Button continueButton;

    private void Start_2()
    {
        // Mengaktifkan fungsi tombol "Skip"
        skipButton.onClick.AddListener(SkipStory_2);

        // Mengaktifkan fungsi tombol "Lanjutkan"
        continueButton.onClick.AddListener(ContinueStory_2);

        // Menonaktifkan UI Canvas cerita secara default
        storyCanvas.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipStory_2();
        }

        // Mengaktifkan tombol "Lanjutkan" dengan tombol keyboard (misalnya tombol "C")
        if (Input.GetKeyDown(KeyCode.C))
        {
            ContinueStory_2();
        }
    }

    private void SkipStory_2()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Desa4");

        // Implementasikan logika skip cerita di sini
    }

    private void ContinueStory_2()
    {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Jika index scene sudah mencapai batas tertentu (misalnya index scene ke-4), kembali ke SampleScene
    if (currentSceneIndex == 11)
    {
        SceneManager.LoadScene("Desa4");
    }
    else
    {
        // Jika belum mencapai batas, lanjut ke scene berikutnya
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
}