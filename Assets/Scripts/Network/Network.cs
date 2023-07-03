using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class Network : MonoBehaviourPunCallbacks
{
    [SerializeField] private string _lobbyScene;
    private void Start()
    {
        PhotonNetwork.NickName = "Player " + Random.Range(1, 1000);
        Debug.LogFormat("Player {0} connected to server", PhotonNetwork.NickName);

        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to master");
        SceneManager.LoadScene(_lobbyScene);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
