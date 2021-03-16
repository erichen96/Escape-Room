﻿using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 15f;
    public float nextTimeToFire = 0f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public AudioSource sound;
    public GameObject impactEffect;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2")){
            Shoot();
        }

        //if(Input.GetButtonDown("Fire2") && Time.time >= nextTimeToFire){
        //     nextTimeToFire = Time.time + 1f/fireRate;
        //     Shoot();
        // }
        
    }

    void Shoot(){
        muzzleFlash.Play();
        sound.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null){
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null){
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);

        }


    }
}
