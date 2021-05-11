using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puzzle_3_Handler : MonoBehaviour
{
    [SerializeField]
    public UnityEvent openDoor1;
    public UnityEvent openDoor2;
    public UnityEvent openDoor3;
    public UnityEvent openDoor4;


    public void CheckAnswer(){
        openDoor1.Invoke();
        openDoor2.Invoke();
        openDoor3.Invoke();
        openDoor4.Invoke();

    }

}
