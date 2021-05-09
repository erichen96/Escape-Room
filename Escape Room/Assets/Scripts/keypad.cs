using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{
    public string curPassword = "1234";
    public string input = "";
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform doorHinge;

    public Transform keypadPos;
    public Transform player;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, keypadPos.position);
        if (distance < 5)
        {
            onTrigger = true;
        }
        else
        {
            onTrigger = false;
            keypadScreen = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            input = "";
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            input = input + "1";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            input = input + "2";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            input = input + "3";
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            input = input + "4";
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            input = input + "5";
        }

        if (Input.GetKeyDown(KeyCode.Alpha6)) {
            input = input + "6";
        }

        if (Input.GetKeyDown(KeyCode.Alpha7)) {
            input = input + "7";
        }

        if (Input.GetKeyDown(KeyCode.Alpha8)) {
            input = input + "8";
        }

        if (Input.GetKeyDown(KeyCode.Alpha9)) {
            input = input + "9";
        }

        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            input = input + "0";
        }

        if (Input.GetKeyDown(KeyCode.Backspace)) {
            input = input.Remove(input.Length - 1);
        }

        if (input == curPassword)
        {
            doorOpen = true;
        }
        else if (input.Length == 4 && input != curPassword)
        {
            keypadScreen = false;
        }

        if(doorOpen)
        {
            doorHinge.transform.position += new Vector3(0, 4, 0);
            //var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 250);
            //doorHinge.rotation = newRot;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
        Cursor.visible = false;
    }

    void OnGUI()
    {
        if (!doorOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect((Screen.width/2) - 100, (Screen.height/2) + 100, 200, 25), "Press 'E' to open keypad");

                if (Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }

            if (keypadScreen)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                GUI.Box(new Rect(550, 200, 320, 450), "");
                GUI.Box(new Rect(555, 205, 310,  25), input);

                if (GUI.Button(new Rect(555, 235, 100, 100), "1"))
                {
                    input = input + "1";
                }

                if (GUI.Button(new Rect(660, 235, 100, 100), "2"))
                {
                    input = input + "2";
                }

                if (GUI.Button(new Rect(765, 235, 100, 100), "3"))
                {
                    input = input + "3";
                }

                if (GUI.Button(new Rect(555, 340, 100, 100), "4"))
                {
                    input = input + "4";
                }

                if (GUI.Button(new Rect(660, 340, 100, 100), "5"))
                {
                    input = input + "5";
                }

                if (GUI.Button(new Rect(765, 340, 100, 100), "6"))
                {
                    input = input + "6";
                }

                if (GUI.Button(new Rect(555, 445, 100, 100), "7"))
                {
                    input = input + "7";
                }

                if (GUI.Button(new Rect(660, 445, 100, 100), "8"))
                {
                    input = input + "8";
                }

                if (GUI.Button(new Rect(765, 445, 100, 100), "9"))
                {
                    input = input + "9";
                }

                if (GUI.Button(new Rect(660, 550, 100, 100), "0"))
                {
                    input = input + "0";
                }

                if (GUI.Button(new Rect(765, 550, 100, 100), "Backspace"))
                {
                    input = input.Remove(input.Length - 1);
                }
            }
        }

    }
}
