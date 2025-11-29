using System.Collections;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [Header("Configuración del boost")]
    public float boostSpeed = 10f;      // Velocidad durante el boost
    public float duration = 3f;         // Duración del boost en segundos

    [Header("Referencias")]
    public PlayerMovement playerMovement; // Referencia al script de movimiento del jugador
    public TrailRenderer trail;           // Trail Renderer para la estela

    private float normalSpeed; // Para guardar la velocidad original del jugador

    void Start()
    {
        if(playerMovement == null)
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        if(trail != null)
        {
            trail.enabled = false; // La estela empieza desactivada
        }

        normalSpeed = playerMovement.speed; // Guardamos velocidad original
    }

    public void ActivateBoost()
    {
        StartCoroutine(BoostRoutine());
    }

    private IEnumerator BoostRoutine()
    {
        // Activar boost
        playerMovement.speed = boostSpeed;

        // Activar estela visual
        if(trail != null)
        {
            trail.enabled = true;
        }

        // Esperar la duración del boost
        yield return new WaitForSeconds(duration);

        // Volver a la velocidad normal
        playerMovement.speed = normalSpeed;

        // Desactivar estela
        if(trail != null)
        {
            trail.enabled = false;
        }
    }
}
