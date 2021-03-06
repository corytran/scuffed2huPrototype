﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire1 : MonoBehaviour
{
    public float startDelay = 0.01f;
    public float spawnInterval = 0.8f;
    public GameObject projectilePrefab;
    public float turnSpeed = 30.0f;
    public float angleDistance = 0.0f;
    public float angleOffset = 180;
    private float angleBound = 360.0f;

    public int i;
    //public int[] angles = { 0, 45, 90, 135, 180, 225, 270, 315, 360 };
    public int angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameState gameStateScript = GameObject.FindWithTag("GameState").GetComponent<GameState>();
        InvokeRepeating("FireGun", startDelay, spawnInterval * gameStateScript.spawnIntervalOffset);
    }

    void FireGun()
    {
        //calculate angles

        /*
        angleDistance += turnSpeed;

        if (angleDistance > angleBound)
        {
            angleOffset -= turnSpeed;

            if(angleDistance == angleBound * 2)
            {
                angleDistance = 0;
            }
        }
        if(angleDistance < angleBound)
        {
            angleOffset += turnSpeed;
        }
        */
   
        for (int i = 0; i < 8; i++)
        {
            //set angle of projectile
            projectilePrefab.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            //create projectiles
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 1), projectilePrefab.transform.rotation);

            angle += 45;
        }
        /*
        //create projectiles
        Instantiate(projectilePrefab, transform.position, transform.rotation * Quaternion.AngleAxis(0 + angleOffset, Vector3.forward));
        Instantiate(projectilePrefab, transform.position, transform.rotation * Quaternion.AngleAxis(40 + angleOffset, Vector3.forward));
        Instantiate(projectilePrefab, transform.position, transform.rotation * Quaternion.AngleAxis(-40 + angleOffset, Vector3.forward));
        */
    }
}
