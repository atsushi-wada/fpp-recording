﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void_NotVisualizingLayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Camera>().cullingMask &= ~(1 << LayerMask.NameToLayer("NotVisualizing"));
    }
}
