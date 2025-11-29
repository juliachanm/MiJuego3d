using UnityEngine;

public class SpeedBoostTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SpeedBoost boost = other.GetComponent<SpeedBoost>();

            if(boost != null)
            {
                boost.ActivateBoost();  // ✔ ESTE MÉTODO SÍ EXISTE
            }

            Destroy(gameObject); 
        }
    }
}
