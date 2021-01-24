﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoFollowPlayer : MonoBehaviour
{
    public float timer = 0;
    public Vector3 position;
    public int speed = 20;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            timer += Time.deltaTime;
            if (timer > 3)
            {
                position = (GameObject.Find("Player").transform.position);
                transform.position = Vector3.MoveTowards(transform.position, position, speed * Time.deltaTime);
            }
        }
    }
}