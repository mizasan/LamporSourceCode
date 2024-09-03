using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndMenu : MonoBehaviour
{
    public GameObject gameEndMenu;

    private void Start()
    {
        // Sembunyikan menu akhir game saat permainan dimulai
        gameEndMenu.SetActive(true);
    }

    public void ShowGameEndMenu()
    {
        // Tampilkan menu akhir game
        gameEndMenu.SetActive(true);

        // Reset state mouse pointer ke default
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    public void Button1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void button2()
    {
        SceneManager.LoadScene("tutorial_scene");
    }

    public void Button3()
    {
        Application.Quit();
        Debug.Log("Player Keluar Permainan");
    }
}
