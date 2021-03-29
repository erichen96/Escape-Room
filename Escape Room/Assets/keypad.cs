﻿using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        if(doorOpen)
        {
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
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
    }

    void OnGUI()
    {
        if (!doorOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open keypad");

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
                GUI.Box(new Rect(  0,   0, 320, 450), "");
                GUI.Box(new Rect(  5,   5, 310,  25), input);

                if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
                {
                    input = input + "1";
                }

                if (GUI.Button(new Rect(110,  35, 100, 100), "2"))
                {
                    input = input + "2";
                }

                if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
                {
                    input = input + "3";
                }

                if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
                {
                    input = input + "4";
                }

                if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
                {
                    input = input + "5";
                }

                if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
                {
                    input = input + "6";
                }

                if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
                {
                    input = input + "7";
                }

                if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
                {
                    input = input + "8";
                }

                if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
                {
                    input = input + "9";
                }

                if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
                {
                    input = input + "0";
                }

                if (GUI.Button(new Rect(215, 350, 100, 100), "Backspace"))
                {
                    input = input.Remove(input.Length - 1);
                }
            }
        }

    }
}