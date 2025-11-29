using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject levelSectionPrefab; // Prefab de sección
    public Transform lastSection; // Última sección generada
    public float sectionLength = 10f; // Largo de cada sección
    public Transform player; // Referencia al jugador (para generación infinita)

    void Start()
    {
        // Generar 5 secciones iniciales
        for (int i = 0; i < 5; i++)
        {
            GenerateSection();
        }
    }

    void Update()
    {
        // Generar nueva sección si el jugador se acerca al final de la última
        if(player != null && lastSection != null)
        {
            if(player.position.z + 20f > lastSection.position.z)
            {
                GenerateSection();
            }
        }
    }

    public void GenerateSection()
    {
        Vector3 spawnPos;

        if(lastSection == null)
        {
            // Primera sección: colocar en origen
            spawnPos = Vector3.zero;
        }
        else
        {
            // Coloca la nueva sección detrás de la última sección en Z
            spawnPos = lastSection.position + new Vector3(0, 0, sectionLength);
        }

        // Instancia la nueva sección
        GameObject newSection = Instantiate(levelSectionPrefab, spawnPos, Quaternion.identity);
        lastSection = newSection.transform;
    }
}
