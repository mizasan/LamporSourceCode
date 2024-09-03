using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private List<string> inventory = new List<string>(); // Daftar untuk menyimpan item yang dikumpulkan oleh pemain

    // Metode ini dipanggil ketika pemain mengambil item
    public void PickupItem(GameObject item)
    {
        inventory.Add(item.name); // Tambahkan nama GameObject ke inventaris
        Debug.Log("Player picked up " + item.name + "! Total items collected: " + inventory.Count);
    }

    // Metode untuk memeriksa apakah pemain memiliki item tertentu
    public bool HasItem(string itemName)
    {
        return inventory.Contains(itemName);
    }
}
