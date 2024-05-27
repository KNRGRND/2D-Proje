using UnityEngine;
using UnityEngine.UI;

public class HealthbarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low = Color.red; // Varsayýlan kýrmýzý
    public Color High = Color.green; // Varsayýlan yeþil

    void Start()
    {
        // Saðlýk barý baþlatýldýðýnda doðru renk ve deðerlere ayarla
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
