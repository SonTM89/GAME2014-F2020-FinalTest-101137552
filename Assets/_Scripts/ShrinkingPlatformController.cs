/*--------------------------------------------------------------
// ShrinkingPlatformController.cs
//
// Control the behavior of a shrinking platform
//
// Created by Tran Minh Son on Dec 13 2020
// StudentID: 101137552
// Date last Modified: Dec 15 2020
// Rev: 1.1
//  
// Copyright © 2020 Tran Minh Son. All rights reserved.
--------------------------------------------------------------*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShrinkingPlatformController : MonoBehaviour
{
    public bool isActive;
    public float platformTimer;

    public PlayerBehaviour player;

    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        platformTimer = 0;
        isActive = false;
        scaleChange = new Vector3(-0.02f * Time.deltaTime, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            platformTimer += Time.deltaTime;
            _Shrink();
        }
        else
        {
            _Expand();
        }
    }

    void _Shrink()
    {
        transform.localScale += scaleChange;
    }

    void _Expand()
    {
        if(transform.localScale.x < 1)
        {
            transform.localScale -= scaleChange;
        }        
    }
}
