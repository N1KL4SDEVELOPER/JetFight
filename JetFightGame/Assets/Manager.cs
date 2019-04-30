using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // <>


    public Transform Spawn;
    public bool connected;
    public GameObject Player;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings("v1");
    }
    private void OnConnectedToMaster()
    {
        Debug.Log("CONNECTED TO MASTER");
        PhotonNetwork.JoinLobby();
    }
    void OnJoinedLobby()
    {
        Debug.Log("CONNECTED TO LOBBY");
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("RANDOM JOIN FAILED");
        PhotonNetwork.CreateRoom(null);
    }
    void OnJoinedRoom()
    {
        connected = true;      
        Player = PhotonNetwork.Instantiate("myPlayer", Spawn.position, Quaternion.identity, 0);     
    }
}
