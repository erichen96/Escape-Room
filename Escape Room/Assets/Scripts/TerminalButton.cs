﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TerminalButton : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    // {
    //     if(Input.GetMouseButtonDown(0)){
    //         PlaySound();
    //     }
        
    }

    public void PlaySound(){
        sound.Play();
        Debug.Log("Button Pressed");
    }
}