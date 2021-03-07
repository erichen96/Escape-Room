using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ColorPadManager : MonoBehaviour
{
    public static ColorPadManager instance;

    public List<GameObject> pads;
    public List<GameObject> boxes;
    public List<Color> possibleColors;

    public int totalCorrectPlacement; //3
    public int currentCorrectPlacement;
    public int placements;

    public Text canvasText;
    public UnityEvent completeEvent;




    //Check if there is only one instance, else destroy to only have one.
    private void Awake(){
        if(instance == null){
            instance = this;
        } else if (instance != this){
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        totalCorrectPlacement = pads.Count;
        currentCorrectPlacement = 0;

        RandomizeColorList();
        AssignColorsToListObjects(boxes);
        RandomizeColorList();
        AssignColorsToListObjects(pads);
        ShuffleBoxOrder();
    }

    public void IncreasePlacement(){

        placements++;
        if(placements == totalCorrectPlacement){
            //Update the canvas text
            canvasText.text = currentCorrectPlacement.ToString();
        }
    }

    public void DecreasePlacement(){
        placements--;
    }

    public void IncreaseCorrectPlacement(){
        currentCorrectPlacement++;

        if(currentCorrectPlacement == totalCorrectPlacement){
            Debug.Log("All Boxes Are Placed Correctly");
            completeEvent.Invoke();
        }
    }

    public void DecreaseCorrectPlacement(){
        currentCorrectPlacement--;
    }




    // Update is called once per frame
    void Update()
    {
        
    }


    void AssignColorsToListObjects(List<GameObject> objects){
            for(int i = 0; i < objects.Count; i++){
                objects[i].GetComponent<Renderer>().material.color = possibleColors[i];
            }
    }
    
    void RandomizeColorList(){

        List<Color> tempList = new List<Color>();
        for(int i = 0; i < possibleColors.Count; i++){
            tempList.Add(possibleColors[i]);
        }


        for(int i = 0; i < possibleColors.Count; i++){
            Color tempColor = possibleColors[i];
            int randomIndex = UnityEngine.Random.Range(i, possibleColors.Count);
            possibleColors[i] = possibleColors[randomIndex];
            possibleColors[randomIndex] = tempColor;
        }
    }

    void ShuffleBoxOrder(){
        int number = 0; //box id
        for(int i = 0; i < boxes.Count; i++){
            GameObject temp = boxes[i];
            int randomIndex = UnityEngine.Random.Range(i, boxes.Count);
            boxes[i] = boxes[randomIndex];
            boxes[randomIndex] = temp;

            boxes[i].GetComponent<PickUpPressureCube>().boxId = number;
            pads[i].GetComponent<PressurePad>().padId = number;
            number++;
        }
    }

}
