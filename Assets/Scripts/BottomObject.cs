using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BottomObject : MonoBehaviour
{
    public GameObject topObject;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        topObject.GetComponent<SphereScrip>().isGrow = true;
        topObject.GetComponent<TriggerWaitingAnimation>().startTimer = true;
        gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
    }
}