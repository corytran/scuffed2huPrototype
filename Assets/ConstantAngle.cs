﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantAngle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = GameObject.Find("PlayerImage").transform.rotation;//* Quaternion.AngleAxis(0, Vector3.forward);
    }
}
