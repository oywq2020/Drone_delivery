﻿using System;
using System.Collections.Generic;
using _Core.Drove.Script.System;
using _Core.Scripts;
using QFramework;
using UnityEngine;

public class InputManager : MonoBehaviour, IController
{
    /// <summary>
    /// Used with InputSystem
    /// </summary>
    private IInputSystem inputSystem;

    void Start()
    {
        inputSystem = this.GetSystem<IInputSystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Listener
        inputSystem.UpdateHolder();
    }
    public IArchitecture GetArchitecture()
    {
        return DroneArchitecture.Interface;
    }
}