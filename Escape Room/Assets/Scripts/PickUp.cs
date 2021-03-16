using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform player;
    public Transform theDestination;
    bool hasPlayer = false;
    private bool holding = false;

    void OnMouseDown(){
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDestination.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }


    void OnMouseUp(){
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;

    }

    void Update(){


        //Added additional way to pickup objects, via key press E.
        //TODO look into ways to prevent grabbing multiple objects by using raycasting.

        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if(dist <= 7.5f){
            hasPlayer = true;
        } else {
            hasPlayer = false;
        }

        if(Input.GetKeyDown(KeyCode.E) && hasPlayer){
            Debug.Log("E key was pressed");
            
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = theDestination.position;
        this.transform.parent = GameObject.Find("Destination").transform;
        holding = true;
        }
        


        if(Input.GetKeyUp(KeyCode.E)){
            Debug.Log("E key was released");
            
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
