using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LastSphere : MonoBehaviour
{
    public GameObject[] disableObjectInFirstPart;

    public GameObject LeftAxe;
    //private HorizontalAxe _horizontalAxeScript;

    private void OnTriggerEnter(Collider other)
    {
        foreach (var gameobj in disableObjectInFirstPart)
        {
            gameobj.GetComponent<SphereScrip>().ChangeColorToStart();
            gameobj.GetComponent<SphereScrip>().isDown = true;
        }

        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        LeftAxe.GetComponent<HorizontalAxe>().isGoHorizontal = true;
        LeftAxe.GetComponent<TriggerWaitingAnimation>().startTimer = true;
        gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
    }
}