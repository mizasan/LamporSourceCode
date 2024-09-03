using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//DUKUN Scene
public class Story_Code : MonoBehaviour
{
    public GameObject Story;
    public Button Skip;
    public Button Lanjut;

    private void Start_Story()
    {
        // Mengaktifkan fungsi tombol "Skip"
        Skip.onClick.AddListener(SkipStory_4);

        // Mengaktifkan fungsi tombol "Lanjutkan"
        Lanjut.onClick.AddListener(ContinueStory_4);

        // Menonaktifkan UI Canvas cerita secara default
        Story.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipStory_4();
        }

        // Mengaktifkan tombol "Lanjutkan" dengan tombol keyboard (misalnya tombol "C")
        if (Input.GetKeyDown(KeyCode.C))
        {
            ContinueStory_4();
        }
    }

    private void SkipStory_4()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Hutan");

        // Implementasikan logika skip cerita di sini
    }

    private void ContinueStory_4()
    {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

    // Jika index scene sudah mencapai batas tertentu (misalnya index scene ke-4), kembali ke SampleScene
    if (currentSceneIndex == 25)
    {
        SceneManager.LoadScene("Hutan");
    }
    else
    {
        // Jika belum mencapai batas, lanjut ke scene berikutnya
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
}