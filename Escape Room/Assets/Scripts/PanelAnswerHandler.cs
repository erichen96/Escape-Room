﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAnswerHandler : MonoBehaviour
{
    [SerializeField]
    public Sprite[] spriteList;
    [SerializeField]
    public int currentImageIndex = 0;
    [SerializeField]
    public GameObject panel;
    // Start is called before the first frame update
    // void Start()
    // {
    // }

    public void UpdateImage(){
        currentImageIndex++;

        if(currentImageIndex > spriteList.Length - 1){
            currentImageIndex = 0;
        }


        panel.GetComponent<Image>().sprite = spriteList[currentImageIndex];
    }

    public void OnMouseDown(){
        UpdateImage();
    }
}