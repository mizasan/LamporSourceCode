using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    // Fungsi ini dipanggil ketika objek lain masuk ke dalam collider kunci
    private void OnTriggerEnter(Collider other)
    {
        // Periksa apakah objek yang menyentuh adalah pemain
        if (other.CompareTag("Player"))
        {
            // Pemanggilan metode yang menandakan bahwa pemain telah mengambil item
            PlayerPickup player = other.GetComponent<PlayerPickup>();
            if (player != null)
            {
                player.PickupItem(gameObject); // Kirimkan referensi GameObject ini ke metode PickupItem
            }

            // Nonaktifkan objek kunci setelah diambil
            gameObject.SetActive(false);
        }
    }
}
