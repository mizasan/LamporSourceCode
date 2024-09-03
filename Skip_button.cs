using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Cerita : MonoBehaviour
{
    // Metode untuk melewatkan atau melewati cerita dan memuat scene berikutnya
    public void Skip(int sceneID)
    {
        SceneManager.LoadScene(sceneID); // Memuat scene dengan ID yang ditentukan
    }
}
