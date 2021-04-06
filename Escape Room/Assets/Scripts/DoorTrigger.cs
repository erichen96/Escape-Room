using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    [SerializeField]
    GameObject door2;
    
    private bool isOpen = false;
    void OnTriggerEnter(Collider col){
        if (col.tag == "Player"){
            if(!isOpen){
        door.transform.position += new Vector3(0,4,0);
        door2.transform.position += new Vector3(0,4,0);
        isOpen = true;
        Debug.Log("Collision Entered");
            }
        }
    }

    void OnTriggerExit(Collider col){
        if(isOpen){
        door.transform.position += new Vector3(0,-4,0);
        door2.transform.position += new Vector3(0,-4,0);
        isOpen = false;
        Debug.Log("Collision Exit");
        }
    }
}
