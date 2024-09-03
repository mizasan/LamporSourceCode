using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Cerita2 : MonoBehaviour
{
    // Metode untuk melewatkan cerita dan memuat scene berikutnya
    public void Skip2(int sceneID)
    {
        SceneManager.LoadScene(sceneID); // Memuat scene dengan ID yang ditentukan
    }
}
