using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject Pause_Menu; 
    // Variabel untuk menyimpan objek menu jeda

    void Start()
    {
        Pause_Menu.SetActive(false);
    }
    private void Update()
    {
        // Mendeteksi ketika tombol Escape ditekan
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // Jika menu jeda sedang aktif, nonaktifkan
            if(Pause_Menu.activeInHierarchy == true)
            {
                Pause_Menu.SetActive(false); // Nonaktifkan menu jeda
                Cursor.visible = false; // Sembunyikan kursor
                Cursor.lockState = CursorLockMode.Locked; // Kunci kursor ke tengah layar\
                Time.timeScale = 1f; // Mengatur timescale ke nilai 1 untuk melanjutkan permainan
            }
            else
            {
                // Jika menu jeda tidak aktif, aktifkan
                Pause_Menu.SetActive(true); // Aktifkan menu jeda
                Cursor.visible = true; // Tampilkan kursor
                Cursor.lockState = CursorLockMode.None; // Bebaskan kursor untuk bergerak bebas
                Time.timeScale = 0f; // Mengatur timescale ke nilai 0 untuk menjeda permainan
            }
        }
    }
    public void Resume_Button()
    {
        // Metode untuk melanjutkan permainan setelah dijeda
        Pause_Menu.SetActive(false); // Nonaktifkan menu jeda
        Cursor.visible = false; // Sembunyikan kursor
        Cursor.lockState = CursorLockMode.Locked; // Kunci kursor ke tengah layar
        Time.timeScale = 1f; // Mengatur timescale ke nilai 1 untuk melanjutkan permainan
    }
    public void Main_Menu_Button()
    {
        // Metode untuk kembali ke menu utama
        SceneManager.LoadScene("Main_Menu"); // Memuat scene "Main_Menu"
    }
}
