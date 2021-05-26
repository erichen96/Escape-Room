using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class GravityGun : NetworkBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 10f, throwForce = 20f, lerpSpeed = 10f;
    [SerializeField] Transform theDestination;

    Rigidbody grabbedRB;

    [Client]
    void Update()
    {
        if(!hasAuthority) {return; }

        if(grabbedRB){
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, theDestination.transform.position, Time.deltaTime * lerpSpeed));

            if(Input.GetMouseButtonDown(0)){
                grabbedRB.isKinematic = false;
                grabbedRB.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                grabbedRB = null;
            }
        }

        if(Input.GetKeyDown(KeyCode.E)){
            if(grabbedRB){
                grabbedRB.isKinematic = false;
                grabbedRB = null;
            } else {
                RaycastHit hit;
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if(Physics.Raycast(ray, out hit, maxGrabDistance) && hit.transform.tag == "PickUps"){
                    grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if(grabbedRB){
                        grabbedRB.isKinematic = true;
                    }
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.E)){
            RaycastHit hit;
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if(Physics.Raycast(ray, out hit, maxGrabDistance) && hit.transform.tag == "Button"){
                Debug.Log(hit.transform.name);
                // hit.SendMessage("UpdateImage");
                // https://forum.unity.com/threads/how-to-use-sendmessage.256340/
                //Changed to below due to overall performance and better use.
                hit.transform.GetComponent<PanelAnswerHandler>().UpdateImage();
            }
        }

        if(Input.GetKeyDown(KeyCode.E)){
            RaycastHit hit;
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if(Physics.Raycast(ray, out hit, maxGrabDistance) && hit.transform.tag == "PuzzleHandler1"){
                Debug.Log(hit.transform.name);

                hit.transform.GetComponent<Puzzle_1_Handler>().CheckAnswer();
            }if(Physics.Raycast(ray, out hit, maxGrabDistance) && hit.transform.tag == "PuzzleHandler2"){
                Debug.Log(hit.transform.name + "Open");

                hit.transform.GetComponent<Puzzle_2_Handler>().CheckAnswer();
            }if(Physics.Raycast(ray, out hit, maxGrabDistance) && hit.transform.tag == "PuzzleHandler3"){
                Debug.Log(hit.transform.name + "Open");

                hit.transform.GetComponent<Puzzle_3_Handler>().CheckAnswer();
            }
             else {
                Debug.Log(hit.transform.name + " Failed");
            }
        
        }
        
    }
}
