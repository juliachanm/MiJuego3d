using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public string nextLevelName; // Nombre de la siguiente escena

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Cargar siguiente nivel
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
