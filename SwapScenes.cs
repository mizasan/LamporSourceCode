using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    void Update()
    {
        // Cek apakah scene yang aktif adalah "Desa1"
        if (SceneManager.GetActiveScene().name == "Hutan")
        {
            // Jika iya, jeda musik desa dengan mengakses instance dari Musik_Desa
            Musik_Desa.instance.GetComponent<AudioSource>().Pause();
        }
    }
}
