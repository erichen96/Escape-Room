using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsCanvases : MonoBehaviour
{
    [SerializeField]
    private CreateandJoinRoomCanvas _createAndJoinRoomCanvas;
    public CreateandJoinRoomCanvas CreateandJoinRoomCanvas {get {return _createAndJoinRoomCanvas;}}

    [SerializeField]
    private CurrentRoomCanvas _currentRoomCanvas;
    public CurrentRoomCanvas CurrentRoomCanvas {get {return _currentRoomCanvas;}}

    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        CreateandJoinRoomCanvas.FirstInitialize(this);
        CurrentRoomCanvas.FirstInitialize(this);
    }
}
