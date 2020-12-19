/*--------------------------------------------------------------
// ShrinkingPlatformController.cs
//
// Control the behavior of a shrinking platform
//
// Created by Tran Minh Son on Dec 18 2020
// StudentID: 101137552
// Date last Modified: Dec 19 2020
// Rev: 1.0
//  
// Copyright © 2020 Tran Minh Son. All rights reserved.
--------------------------------------------------------------*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum ShrinkSounds
{
    SHRINKING,
    EXPANDING,
}

public class ShrinkingPlatformController : MonoBehaviour
{
    public Transform start;
    public Transform end;
    
    public bool isActive;

    private Vector3 scaleChange; // shrinking and expanding value
    private Vector3 distance; // moving distance

    public AudioSource[] sounds; // Sounds use for shrinking and expanding

    // Start is called before the first frame update
    void Start()
    {
        distance = end.position - start.position;

        isActive = false;

        scaleChange = new Vector3(-0.1f * Time.deltaTime, 0.0f, 0.0f);

        sounds = GetComponentsInParent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();

        if (isActive)
        {           
            _Shrink();
        }
        else
        {
            _Expand();
        }
    }

    // Moving platform slightly up and down
    void _Move()
    {
        var distanceY = (distance.y > 0) ? start.position.y + Mathf.PingPong(0.2f * Time.time, distance.y) : start.position.y;

        transform.position = new Vector3(start.position.x, distanceY, 0.0f);
    }

    // Shrinking platform
    void _Shrink()
    {
        sounds[(int)ShrinkSounds.SHRINKING].Play();
        transform.localScale += scaleChange;
    }

    // Expanding platform
    void _Expand()
    {
        if(transform.localScale.x < 1)
        {
            sounds[(int)ShrinkSounds.EXPANDING].Play();
            transform.localScale -= scaleChange;
        }        
    }

    public void Reset()
    {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}