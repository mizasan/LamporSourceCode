using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deathscene1 : MonoBehaviour
{
    public GameObject deathCanvas;
    public Button restartButton;

    private void Start_Scene()
    {
        // Mengaktifkan fungsi tombol "Restart"
        restartButton.onClick.AddListener(restart);
        // Menonaktifkan UI Canvas cerita secara default
        deathCanvas.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            restart();
        }
    }
    private void restart()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Hutan");
        // Implementasikan logika skip cerita di sini
    }
}
