using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Script untuk mengontrol menu utama dalam game
public class backscene : MonoBehaviour
{
    public GameObject Canvas;
    public Button Backbutton;
        private void back()
    {
        // Mengaktifkan fungsi tombol "Skip"
        Backbutton.onClick.AddListener(backbutton);
        // Menonaktifkan UI Canvas cerita secara default
        Canvas.SetActive(true);
    }

    private void Update()
    {
        // Mengaktifkan tombol "Skip" dengan tombol keyboard (misalnya tombol "S")
        if (Input.GetKeyDown(KeyCode.S))
        {
            backbutton();
        }
    }
    public void backbutton()
    {
            if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Main_Menu");
        }
    }
}