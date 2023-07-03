using Photon.Pun;
using UnityEngine;

public abstract class PlayerSelecter<T> : MonoBehaviour where T : Component
{
    [SerializeField] private PlayerSpawner _spawner;
    private T _player;

    public T Player => _player;

    private void Awake()
    {
        _spawner.CreatePlayer.AddListener(TrySelectPlayer);
    }
    private void TrySelectPlayer(PhotonView player)
    {
        if (player.IsMine)
            _player = player.GetComponent<T>();
    }
}
