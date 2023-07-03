using UnityEngine;
using Photon.Pun;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Transform shootPosition;

    public void Shoot()
    {
        PhotonNetwork.Instantiate(_bulletPrefab.name, shootPosition.position, transform.rotation);
    }
}
