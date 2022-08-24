using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TriggerWaitingAnimation : MonoBehaviour
{
    [SerializeField] private float timerWaitingTouch;
    private float _timer;
    public bool startTimer;


    private void Start()
    {
        _timer = timerWaitingTouch;
    }

    public void Update()
    {
        if (!startTimer) return;
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
        }
        else
        {
            Debug.Log("TIME FOR NOCHMAL!");
            _timer = timerWaitingTouch;
            //TODO Place TRIGGER FOR ANIMATION in the script and send here false for the startTimer = false
        }
    }
}