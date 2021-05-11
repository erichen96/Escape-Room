﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateandJoinRoomCanvas : MonoBehaviour
{
    [SerializeField]
    private CreateRoomMenu _createRoomMenu;

    [SerializeField]
    private RoomListingsMenu _roomListingsMenu;

    private RoomsCanvases _roomsCanvases;
    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomsCanvases = canvases;
        _createRoomMenu.FirstInitialize(canvases);
        _roomListingsMenu.FirstInitialize(canvases);
    }
}
