using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMorseCode : MonoBehaviour
{
    [SerializeField]
    public AudioSource adSource;
    public AudioClip[] adClips;

    

    void OnMouseDown(){
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound(){
        yield return null;
        for(int i = 0; i < adClips.Length; i++){
            adSource.clip = adClips[i];

            adSource.Play();
            Debug.Log("Play Sound" + i);

            while(adSource.isPlaying){
                yield return null;
            }
        }
        Debug.Log("Button Pressed");
    }
}
