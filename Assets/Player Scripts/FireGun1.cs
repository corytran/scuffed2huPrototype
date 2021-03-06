﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun1 : MonoBehaviour
{
    public float spawnInterval = 0.05f;
    public float bulletDamage = 2.0f;
    public GameObject projectilePrefab;
    public GameObject player;
    public PlayerController playerControllerScript;

    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        //initialize the playerControllerScript object
        playerControllerScript = GameObject.FindWithTag("Player").GetComponent<PlayerController>(); 

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // check for user input of left mouse button
        if (Input.GetMouseButton(0) && playerControllerScript.ammoCount != 0 && timer > spawnInterval)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            //create projectile
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 2), transform.rotation);
            //decrement ammo by 1
            playerControllerScript.ammoCount -= 1;
            timer = 0;
        }
    }
}
