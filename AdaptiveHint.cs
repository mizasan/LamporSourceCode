using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AdaptiveHint : MonoBehaviour
{
    public Text hintText; // Referensi ke UI Text yang akan menampilkan petunjuk
    public float hintDelay = 30.0f; // Waktu (dalam detik) sebelum petunjuk muncul
    public float hintDisplayDuration = 10.0f;
    private float timeSpent = 0.0f; // Waktu yang dihabiskan di area tertentu
    private bool hintShown = false; // Status apakah petunjuk sudah ditampilkan

    void Start()
    {
        hintText.gameObject.SetActive(false); // Sembunyikan teks petunjuk di awal
        Debug.Log("HintText initialized and hidden.");
    }

    void Update()
    {
        if (!hintShown)
        {
            timeSpent += Time.deltaTime; // Tambah waktu yang dihabiskan
            if (timeSpent > hintDelay)
            {
                ShowHint(); // Tampilkan petunjuk
                hintShown = true; // Tandai bahwa petunjuk sudah ditampilkan
            }
        }
    }

    public void ShowHint()
    {
        hintText.gameObject.SetActive(true); // Tampilkan teks petunjuk, Isi teks petunjuk sesuai kebutuhan
        StartCoroutine(HideHintAfterDelay(hintDisplayDuration));// Mulai coroutine untuk menyembunyikan petunjuk setelah waktu tertentu
        Debug.Log("Showing hint");
    }
    IEnumerator HideHintAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        hintText.gameObject.SetActive(false); // Sembunyikan teks petunjuk
        Debug.Log("Hint hidden after delay.");
        timeSpent = 0.0f; // Reset waktu yang dihabiskan
        hintShown = false; // Reset status petunjuk
    }
    public void ResetHint()
    {
        hintText.gameObject.SetActive(false); // Sembunyikan teks petunjuk
        timeSpent = 0.0f; // Reset waktu yang dihabiskan
        hintShown = false; // Reset status petunjuk
        Debug.Log("Hint reset.");
    }
}
