using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Bu Broto Scene
public class Pakbroto : MonoBehaviour
{
    public GameObject storyCanvaspb;
    public Button skipButtonpb;
    public Button continueButtonpb;

    private void Start()
    {
        // Mengaktifkan fungsi tombol "Skip"
        skipButtonpb.onClick.AddListener(SkipStory_pb);

        // Mengaktifkan fungsi tombol "Lanjutkan"
        continueButtonpb.onClick.AddListener(ContinueStory_pb);

        // Menonaktifkan UI Canvas cerita secara default
        storyCanvaspb.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipStory_pb();
        }

        // Mengaktifkan tombol "Lanjutkan" dengan tombol keyboard (misalnya tombol "C")
        if (Input.GetKeyDown(KeyCode.C))
        {
            ContinueStory_pb();
        }
    }

    private void SkipStory_pb()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Main_Menu");

        // Implementasikan logika skip cerita di sini
    }

    private void ContinueStory_pb()
    {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Jika index scene sudah mencapai batas tertentu (misalnya index scene ke-4), kembali ke SampleScene
    if (currentSceneIndex == 36)
    {
        SceneManager.LoadScene("Main_Menu");
    }
    else
    {
        // Jika belum mencapai batas, lanjut ke scene berikutnya
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
}