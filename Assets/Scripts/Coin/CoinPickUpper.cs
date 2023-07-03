using Photon.Pun;
using System;
using UnityEngine;
using UnityEngine.Events;

public class CoinPickUpper : MonoBehaviour, IPunObservable
{
    [SerializeField] private int _money;

    public UnityEvent<int> ChangeMoney;
    public void TakeCoin(int coinNominal)
    {
        if (coinNominal < 0)
            throw new InvalidOperationException();

        _money += coinNominal;
        ChangeMoney?.Invoke(_money);
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
            stream.SendNext(_money);
        else
            _money = (int)stream.ReceiveNext();
    }
}
