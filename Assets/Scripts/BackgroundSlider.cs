using UnityEngine;
using UnityEngine.UI;

public class BackgroundColorSlider : MonoBehaviour
{
    public GameConfig config;
    public Slider slider;

    void Start()
    {
        slider.onValueChanged.AddListener(ChangeColor);
    }

    void ChangeColor(float value)
    {
        Color color = new Color(value, value, value); // escala de grises simple
        config.SetBackgroundColor(color);
    }
}
