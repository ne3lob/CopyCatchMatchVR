using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAxe : MonoBehaviour
{
    public GameObject RightSphere;
    public int delayHorizontalAxe;
    public bool isGoHorizontal;

    private void Update()
    {
        if (isGoHorizontal)
        {
            StartCoroutine(StartFirstPartWithDelay());
        }
    }

    private IEnumerator StartFirstPartWithDelay()
    {
        yield return new WaitForSeconds(delayHorizontalAxe);
        gameObject.GetComponent<SphereScrip>().isGrow = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        RightSphere.GetComponent<SphereScrip>().isGrow = true;
        RightSphere.GetComponent<TriggerWaitingAnimation>().startTimer = true;
        gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
    }
}