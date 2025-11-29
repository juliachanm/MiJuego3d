using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
{
    if(other.CompareTag("Player"))
    {
        FindObjectOfType<ScoreManager>().AddScore(1);
        Destroy(gameObject);
    }
}
}
