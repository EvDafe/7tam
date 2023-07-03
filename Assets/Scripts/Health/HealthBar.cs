using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : PlayerSelecter<PlayerHealth>
{
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        Player.TakedDamage.AddListener(UpdateFill);
    }

    private void UpdateFill()
    {
        float fillAmount = Player.CurrentHealth / Player.MaxHealth;
        _image.fillAmount = fillAmount;
    }
}
