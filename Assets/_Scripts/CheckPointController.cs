/*--------------------------------------------------------------
// CheckPointController.cs
//
// Setting check point to spawn player at a specific point
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
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Transform spawnPoint;
    public PlayerBehaviour player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.spawnPoint = spawnPoint;
        }
    }
}
