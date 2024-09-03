using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jumpscare_Kunti : MonoBehaviour
{
    public GameObject CanvasJumpscare;
    public Button restartButton2;

    private void Start()
    {
        // Mengaktifkan fungsi tombol "Restart"
        restartButton2.onClick.AddListener(Restart2);
        // Menonaktifkan UI Canvas cerita secara default
        CanvasJumpscare.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            Restart2();
        }
    }

    private void Restart2()
    {
        // Menonaktifkan UI Canvas cerita
        SceneManager.LoadScene("Hutan");
        // Implementasikan logika skip cerita di sini
    }
}
