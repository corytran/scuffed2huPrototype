﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRenderCamera : MonoBehaviour
{
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.worldCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
