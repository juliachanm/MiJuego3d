using UnityEngine;
using UnityEngine.UI;

public class PlayerColorSlider : MonoBehaviour
{
    public GameConfig config;
    public Slider slider;

    void Start()
    {
        slider.onValueChanged.AddListener(ChangeColor);
    }

    void ChangeColor(float value)
    {
        Color color = new Color(value, 0, 0); // rojo → intensidad desde slider
        config.SetPlayerColor(color);
    }
}
