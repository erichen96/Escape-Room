﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Puzzle_2_Handler : MonoBehaviour
{
    
    [SerializeField]
    public Sprite Answer1;
    public Sprite Answer2;
    public Sprite Answer3;
    public Sprite Answer4;


    [SerializeField]
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;


    Image _Image1;
    Image _Image2;
    Image _Image3;
    Image _Image4;

    public UnityEvent openDoor2;

    public GameObject Door;
    public Material CompletePuzzleColor;
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update(){
    //         _Image1 = Image1.GetComponent<Image>();
    //         _Image2 = Image2.GetComponent<Image>();
    //         _Image3 = Image3.GetComponent<Image>();
    //         _Image4 = Image4.GetComponent<Image>();




    //     if((_Image1.sprite == Answer1) && (_Image2.sprite == Answer2)
    // && (_Image3.sprite == Answer3) && (_Image4.sprite == Answer4)){
    //         Debug.Log("Open Door 2");
    //     }
        
    // }

    public void CheckAnswer(){
            _Image1 = Image1.GetComponent<Image>();
            _Image2 = Image2.GetComponent<Image>();
            _Image3 = Image3.GetComponent<Image>();
            _Image4 = Image4.GetComponent<Image>();




        if((_Image1.sprite == Answer1) && (_Image2.sprite == Answer2)
    && (_Image3.sprite == Answer3) && (_Image4.sprite == Answer4)){
            Debug.Log("Open Door 2");
            var mats = Door.GetComponent<Renderer>().sharedMaterials;
            mats[0] = CompletePuzzleColor;
            Door.GetComponent<Renderer>().sharedMaterials = mats;
            openDoor2.Invoke();
        }
    }
    // void CheckImagePuzzle(){
    //     if(Bane.GetComponent<Renderer>().sharedMaterials[1] == AnswerBane){
    //         Debug.Log("Open Door");
    //     }
    // }
}
