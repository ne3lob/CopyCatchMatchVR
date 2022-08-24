using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FowardMiddle : MonoBehaviour
{
    [SerializeField] GameObject nextSphere;
    [SerializeField] GameObject backSphere;
    [SerializeField] private bool firstTouch;
    [SerializeField] private bool secondTouch;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (firstTouch)
        {
            gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
            nextSphere.GetComponent<SphereScrip>().isGrow = true;
            nextSphere.GetComponent<TriggerWaitingAnimation>().startTimer = true;
            gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
            secondTouch = true;
            firstTouch = false;
        }

        else if (secondTouch)
        {
            gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
            backSphere.GetComponent<SphereScrip>().isGrow = true;
            backSphere.GetComponent<TriggerWaitingAnimation>().startTimer = true;
            gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
            secondTouch = false;
        }
    }
}