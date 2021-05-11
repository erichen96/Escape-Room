using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnContact01 : MonoBehaviour
{
    [SerializeField]
    Transform TeleportDestination;
    [SerializeField]
    GameObject Player;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TeleportPlatform01")
        {
            Player.GetComponent<CharacterController>().enabled = false;
            Player.transform.position = TeleportDestination.transform.position;
            Debug.Log("Teleporting");
            Player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
