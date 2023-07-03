using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class LeaveButton : MonoBehaviour
{
    [SerializeField] private string _lobbyScene;
    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene(_lobbyScene);
    }
}
