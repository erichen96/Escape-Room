using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    [Header("Audio")]
    public GameObject JumpSound;

    Vector3 velocity;
    bool isGrounded;

    private float currentJumpHeight;


    void Start(){
        currentJumpHeight = jumpHeight;
    }


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(currentJumpHeight * -2f * gravity);
            JumpSound.SetActive (true);
            JumpSound.SetActive (false);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit){
        switch(hit.gameObject.tag){
             case "JumpPad":
                currentJumpHeight = 25f;
                break;

            case "Ground":
                currentJumpHeight = jumpHeight;
                break;
        }
    }
}
