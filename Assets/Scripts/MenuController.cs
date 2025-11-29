using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel1"); // Carga el primer nivel
    }

    public void QuitGame()
    {
        Application.Quit(); // Sale del juego
    }
}
