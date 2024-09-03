using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keygate : MonoBehaviour
{
    // Nama item yang diperlukan untuk membuka gerbang
    public GameObject requiredItem;  // Drag item dari Hierarchy ke sini di Inspector

    // Fungsi ini dipanggil ketika objek lain masuk ke dalam collider item
    private void OnTriggerEnter(Collider other)
    {
        // Periksa apakah objek yang menyentuh adalah pemain
        if (other.CompareTag("Player"))
        {
            // Mendapatkan skrip PlayerPickup dari pemain
            PlayerPickup player = other.GetComponent<PlayerPickup>();

            // Periksa apakah pemain memiliki item yang diperlukan
            if (player != null && player.HasItem(requiredItem.name)) // Memeriksa berdasarkan nama GameObject
            {
                // Nonaktifkan objek item (jika ingin item ini hilang setelah digunakan)
                gameObject.SetActive(false);
            }
            else
            {
                // Jika pemain tidak memiliki item yang diperlukan, tampilkan pesan atau lakukan tindakan lain
                Debug.Log("Gerbang terkunci! Anda memerlukan " + requiredItem.name + " untuk membuka gerbang ini.");
            }
        }
    }
}
