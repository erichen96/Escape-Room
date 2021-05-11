using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puzzle_1_Handler : MonoBehaviour
{
    [SerializeField]
    public Material AnswerBane;
    public Material AnswerCircle;
    public Material AnswerFlower;
    public Material AnswerSpring;
    public Material AnswerSun;
    public Material AnswerSunrise;
    public Material AnswerSunset;
    public Material AnswerWater;
    public Material AnswerWine;
    public Material AnswerWinter;

    [SerializeField]
    public GameObject Bane;
    public GameObject Circle;
    public GameObject Flower;
    public GameObject Spring;
    public GameObject Sun;
    public GameObject Sunrise;
    public GameObject Sunset;
    public GameObject Water;
    public GameObject Wine;
    public GameObject Winter;

    [SerializeField]
    public GameObject Door;
    public UnityEvent openDoor;
    public Material CompletePuzzleColor;


    public void CheckAnswer(){
        if((Bane.GetComponent<Renderer>().sharedMaterials[1] == AnswerBane) && (Circle.GetComponent<Renderer>().sharedMaterials[1] == AnswerCircle)
    && (Flower.GetComponent<Renderer>().sharedMaterials[1] == AnswerFlower) && (Spring.GetComponent<Renderer>().sharedMaterials[1] == AnswerSpring)
    && (Sun.GetComponent<Renderer>().sharedMaterials[1] == AnswerSun) && (Sunrise.GetComponent<Renderer>().sharedMaterials[1] == AnswerSunrise)
    && (Sunset.GetComponent<Renderer>().sharedMaterials[1] == AnswerSunset) && (Water.GetComponent<Renderer>().sharedMaterials[1] == AnswerWater)
    && (Wine.GetComponent<Renderer>().sharedMaterials[1] == AnswerWine) && (Winter.GetComponent<Renderer>().sharedMaterials[1] == AnswerWinter)){
            Debug.Log("Open Door");
            var mats = Door.GetComponent<Renderer>().sharedMaterials;
            mats[0] = CompletePuzzleColor;
            Door.GetComponent<Renderer>().sharedMaterials = mats;
            
            openDoor.Invoke();
        }
    }
}
