﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GenericScripts;
using UnityEngine;
using EventType = GenericScripts.EventType;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] showOnPauseObjects;
    [SerializeField] private GameObject[] hideOnPauseObjects;
    
    void Start()
    {
        EventManager.Instance.AddListener(EventType.Pause, (type, sender, o) =>
        {
            foreach (var pauseObject in showOnPauseObjects) pauseObject.SetActive(true);
            foreach (var pauseObject in hideOnPauseObjects) pauseObject.SetActive(false);
        });
        
        EventManager.Instance.AddListener(EventType.Resume, (type, sender, o) =>
        {
            foreach (var pauseObject in showOnPauseObjects) pauseObject.SetActive(false);
            foreach (var pauseObject in hideOnPauseObjects) pauseObject.SetActive(true);
        });
    }
}
