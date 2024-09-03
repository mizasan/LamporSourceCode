using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script untuk memindahkan pemain ke scene lain saat pemain menyentuh objek ini
public class nextscene : MonoBehaviour
{
    public string scenename; // Nama scene yang akan dimuat
    public GameObject ConText;
    private bool playerInRange = false; // Flag untuk memeriksa apakah pemain berada dalam jangkauan
    private GameObject player; // Referensi ke pemain

    void Start()
    {
       playerInRange = false;
       ConText.SetActive(false);
    }
    // Dipanggil saat objek ini bersentuhan dengan objek lain yang memiliki Collider
    void OnTriggerEnter(Collider other)
    {
        // Memeriksa apakah objek yang bersentuhan memiliki tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            player = other.gameObject; // Menyimpan referensi ke pemain
            ConText.SetActive(true);
        }
    }

    // Dipanggil saat objek ini keluar dari Collider
    void OnTriggerExit(Collider other)
    {
        // Memeriksa apakah objek yang keluar memiliki tag "Player"
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            player = null; // Menghapus referensi ke pemain
            ConText.SetActive(false);
        }
    }

    void Update()
    {
        // Memeriksa apakah pemain berada dalam jangkauan dan menekan tombol "E"
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            // Memuat scene dengan nama sesuai variabel scenename
            SceneManager.LoadScene(scenename);
        }
    }
}