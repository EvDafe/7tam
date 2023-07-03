using Photon.Pun;
using UnityEngine;
using UnityEngine.Events;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnRadius;
    [SerializeField] private Transform _centerPosition;
    [SerializeField] private PhotonView _playerPrefab;

    private float SpawnOffset => Random.Range(0, _spawnRadius);
    private PhotonView _createdPlayer;

    public UnityEvent<PhotonView> CreatePlayer;
    private void OnEnable()
    {
        var spawnPositionX = _centerPosition.position.x + SpawnOffset;
        var spawnPositionY = _centerPosition.position.y + SpawnOffset;
        var spawnPosition = new Vector2(spawnPositionX, spawnPositionY);
        _createdPlayer = PhotonNetwork.Instantiate(_playerPrefab.name, spawnPosition, Quaternion.identity).GetComponent<PhotonView>();
        CreatePlayer?.Invoke(_createdPlayer);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_centerPosition.position, _spawnRadius);
    }
}
