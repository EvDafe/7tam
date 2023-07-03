using TMPro;
using UnityEngine;
using Photon.Pun;

public class HostButton : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;

    public void HostRoom()
    {
        PhotonNetwork.CreateRoom(_inputField.text, new Photon.Realtime.RoomOptions { MaxPlayers = 4 });
    }
}
