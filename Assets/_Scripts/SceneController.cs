/*--------------------------------------------------------------
// SceneController.cs
//
// Load new scene
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
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
