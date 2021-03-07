using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    public int padId;
    int objectsOnPad = 0;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.GetComponent<PickUpPressureCube>() != null){
            objectsOnPad++;

            if(other.gameObject.GetComponent<PickUpPressureCube>().ReturnBoxId() == padId){
                //Increases the number of correct placements
                ColorPadManager.instance.IncreaseCorrectPlacement();
            }

            ColorPadManager.instance.IncreasePlacement();
        }

    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.GetComponent<PickUpPressureCube>() != null){
            objectsOnPad--;
            //Decreases the number of placements
            ColorPadManager.instance.DecreasePlacement();
            if(other.gameObject.GetComponent<PickUpPressureCube>().ReturnBoxId() == padId){
                //Decrease the number of correct placements
                ColorPadManager.instance.DecreaseCorrectPlacement();
            }
        }

    }
}
