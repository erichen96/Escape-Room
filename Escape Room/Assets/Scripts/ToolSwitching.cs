
using UnityEngine;

public class ToolSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;
    public GameObject FirstPersonPlayer;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
        
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f){
            Debug.Log("Scrolling");
            if(selectedWeapon >= transform.childCount - 1){
                selectedWeapon = 0;
            } else {
            selectedWeapon++;
            }
        }

        if(Input.GetAxis("Mouse ScrollWheel") < 0f){
            if(selectedWeapon <= 0){
                selectedWeapon = transform.childCount - 1;
            } else {
            selectedWeapon--;
            }
        }

        if(previousSelectedWeapon != selectedWeapon){
            SelectWeapon();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)){
            selectedWeapon = 0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2){
            selectedWeapon = 1;
        }

        if(Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3){
            selectedWeapon = 2;
        }

        if(previousSelectedWeapon != selectedWeapon){
            SelectWeapon();
        }


        canHold();
    }

    void canHold(){
        if(selectedWeapon == 0){
            FirstPersonPlayer.GetComponent<GravityGun>().enabled = true;
        } else {
            FirstPersonPlayer.GetComponent<GravityGun>().enabled = false;
        }
    }

    void SelectWeapon(){
        int i = 0;
        foreach(Transform weapon in transform){
            if(i == selectedWeapon){
                weapon.gameObject.SetActive(true);        
            } else {
                weapon.gameObject.SetActive(false);
            }
            
            i++;
        }
    }
}
