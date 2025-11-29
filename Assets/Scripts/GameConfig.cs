using UnityEngine;

public class GameConfig : MonoBehaviour
{
    public Camera mainCamera;
    public Renderer playerRenderer;

    public void SetBackgroundColor(Color color)
    {
        mainCamera.backgroundColor = color;
    }

    public void SetPlayerColor(Color color)
    {
        playerRenderer.material.color = color;
    }


}
