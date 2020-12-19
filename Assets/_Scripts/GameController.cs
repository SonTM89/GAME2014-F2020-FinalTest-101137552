/*--------------------------------------------------------------
// GameController.cs
//
// Holding Bullet pool and moving patform objects
//
// Created by Tran Minh Son on Dec 18 2020
// StudentID: 101137552
// Date last Modified: Dec 18 2020
// Rev: 1.0
//  
// Copyright © 2020 Tran Minh Son. All rights reserved.
--------------------------------------------------------------*/


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Bullet Related")]
    public int MaxBullets;
    public BulletType enemyBulletType;
    public BulletType playerBulletType;

    [Header("Moving Platforms")] 
    public List<MovingPlatformController> movingPlatforms;
    public List<ShrinkingPlatformController> shrinkingPlatforms;

    // Start is called before the first frame update
    void Start()
    {
        movingPlatforms = FindObjectsOfType<MovingPlatformController>().ToList();
        shrinkingPlatforms = FindObjectsOfType<ShrinkingPlatformController>().ToList();


        // Kickoff the BulletManager
        BulletManager.Instance().Init(MaxBullets, enemyBulletType, playerBulletType);
    }

    public void ResetAllPlatforms()
    {
        foreach (var platform in movingPlatforms)
        {
            platform.Reset();
        }

        foreach (var platform in shrinkingPlatforms)
        {
            platform.Reset();
        }
    }

}
