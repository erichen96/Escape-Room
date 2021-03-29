﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    void OnCollisionEnter(Collision col){
        if (col.gameObject.layer != 8)
      {
        door.transform.position += new Vector3(0,8,0);
        Debug.Log("Collision Entered");
    }
    }

    void OnCollisionExit(Collision col){
        door.transform.position += new Vector3(0,-8,0);
        Debug.Log("Collision Exit");
    }
}
