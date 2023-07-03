using UnityEngine;
using TMPro;
using Photon.Pun;

public class JoinButton : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField _inputField;

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(_inputField.text);
    }
    
}
