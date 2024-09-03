using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare_Animation_Collider : MonoBehaviour
{
    public Animator animator; // Animator untuk mengontrol animasi
    public string nextSceneName; // Nama scene yang akan dipindahkan setelah jumpscare

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Memainkan animasi jumpscare atau death scene
            animator.SetTrigger("jumpscare"); // Ganti "JumpscareTrigger" dengan nama trigger animasi jumpscare atau death scene

            // Melakukan perpindahan scene setelah animasi jumpscare selesai
            Invoke("ChangeScene", 1f);
        }
    }
    private void ChangeScene()
    {
        // Memuat scene berikutnya
        SceneManager.LoadScene(nextSceneName);
    }
}