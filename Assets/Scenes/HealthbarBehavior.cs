using UnityEngine;
using UnityEngine.UI;

public class HealthbarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low = Color.red; // Varsay�lan k�rm�z�
    public Color High = Color.green; // Varsay�lan ye�il

    void Start()
    {
        // Sa�l�k bar� ba�lat�ld���nda do�ru renk ve de�erlere ayarla
        SetHealth(Slider.maxValue, Slider.maxValue);
    }

    public void SetHealth(float health, float maxHealth)
    {
        Slider.value = health;
        Slider.maxValue = maxHealth;

        float fillValue = Slider.normalizedValue;

        // Slider fill area rengini ayarla
        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, fillValue);
    }
}
