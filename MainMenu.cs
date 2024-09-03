using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Script untuk mengontrol menu utama dalam game
public class Main_Menu : MonoBehaviour
{
    // Method untuk memuat scene berikutnya dalam urutan build index
    public void Button1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        //Memuat scene berikutnya dalam urutan build index.
    }

    public void button2()
    {
        SceneManager.LoadScene("tutorial_scene");
    }

    // Method untuk keluar dari permainan
    public void Button3()
    {
        Application.Quit();
        Debug.Log("Player Keluar Permainan");
    }
}
