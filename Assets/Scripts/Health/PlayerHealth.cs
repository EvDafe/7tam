using Photon.Pun;
using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour, IPunObservable
{
    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    public UnityEvent TakedDamage;
    public UnityEvent Died;


    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
            throw new ArgumentException();

        _currentHealth -= damage;
        TakedDamage?.Invoke();
        CheckDeath();
    }
    private void CheckDeath()
    {
        if (_currentHealth <= 0)
            Die();
    }
    private void Die()
    {
        PhotonNetwork.Destroy(gameObject);
        Died?.Invoke();
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
            stream.SendNext(_currentHealth);
        else
            _currentHealth = (float)stream.ReceiveNext();
    }
}
