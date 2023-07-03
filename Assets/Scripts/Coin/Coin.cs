using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinNominal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out CoinPickUpper coinPickUpper))
        {
            coinPickUpper.TakeCoin(_coinNominal);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out CoinPickUpper pickUpper))
        {
            pickUpper.TakeCoin(_coinNominal);
            Destroy(gameObject);
        }
    }
}
