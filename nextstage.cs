using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage : MonoBehaviour
{
    public string scenename; // Nama scene yang akan dimuat
    private GameObject player; // Referensi ke pemain

    // Dipanggil saat objek ini bersentuhan dengan objek lain yang memiliki Collider
    void OnTriggerEnter(Collider other)
    {
        // Memeriksa apakah objek yang bersentuhan memiliki tag "Player"
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scenename);
        }
    }
}