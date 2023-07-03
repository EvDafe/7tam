using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class CoinText : PlayerSelecter<CoinPickUpper>
{
    private TMP_Text _text;

    private void Start()
    {
        _text = GetComponent<TMP_Text>();
        Player.ChangeMoney.AddListener(SetText);
        Debug.Log(Player);
    }
    public void SetText(int money)
    {
        _text.text = money.ToString();
    }
}
