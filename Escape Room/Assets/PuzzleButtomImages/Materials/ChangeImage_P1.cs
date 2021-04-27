using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage_P1 : MonoBehaviour
{
    public Material material1;
    public Material material2;

    public bool FirstMaterial = false;
    public bool SecondMaterial = false;
    
    void Start()
    {
    }

    void OnMouseDown(){
        if(FirstMaterial){
            var mats = GetComponent<Renderer>().sharedMaterials;
            mats[1] = material1;
            SecondMaterial = true;
            FirstMaterial = false;
            GetComponent<Renderer>().sharedMaterials = mats;
        }
        else if(SecondMaterial){
            var mats = GetComponent<Renderer>().sharedMaterials;
            mats[1] = material2;
            FirstMaterial = true;
            SecondMaterial = false;
            GetComponent<Renderer>().sharedMaterials = mats;
        }
    }
}
