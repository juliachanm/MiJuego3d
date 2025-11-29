using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : MonoBehaviour
{
    public Transform player;          // Referencia al jugador
    public float distanceToFinish = 200f; // Distancia para pasar de nivel
    public string nextLevel;          // Nombre del siguiente nivel
    public GameObject endPanel;       // Panel con mensaje final (opcional)

    void Update()
    {
        if(player.position.z >= distanceToFinish)
        {
            if(!string.IsNullOrEmpty(nextLevel))
            {
                // Si hay siguiente nivel, lo carga
                SceneManager.LoadScene(nextLevel);
            }
            else if(endPanel != null)
            {
                // Si no hay siguiente nivel, muestra panel final
                endPanel.SetActive(true);
            }
            else
            {
                // Si no hay panel, solo mensaje en consola
                Debug.Log("¡Juego Terminado!");
            }
        }
    }
}
