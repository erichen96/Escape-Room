using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class TeleportOnContact : NetworkBehaviour
{
    [SerializeField] 
    Transform TeleportDestination;
    [SerializeField]
    GameObject Player;

    [Client]
    public void OnTriggerEnter(Collider collision){
        if(!hasAuthority) {return; }

        if(collision.gameObject.tag == "TeleportPlatform"){
            Player.GetComponent<CharacterController>().enabled = false;
            Player.transform.position = TeleportDestination.transform.position;
            Debug.Log("Teleporting");
            Player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
