﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
[SerializeField]
private Text _roomName;

private RoomsCanvases _roomsCanvases;
public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomsCanvases = canvases;
    }

public void onClick_CreateRoom()
{
    if (!PhotonNetwork.IsConnected)
        return;

    RoomOptions options = new RoomOptions();
    options.MaxPlayers = 4;
    PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
}

    public override void OnCreatedRoom()
    {
       Debug.Log("Created room successfully");
       _roomsCanvases.CurrentRoomCanvas.Show();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Creation Failed" + message);
    }

}
