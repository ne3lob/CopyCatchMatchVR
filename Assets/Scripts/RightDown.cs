using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDown : MonoBehaviour
{
    [SerializeField] private GameObject nextSphere;

    [SerializeField] private bool firstTouch;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (firstTouch)
        {
            gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
            nextSphere.GetComponent<SphereScrip>().isGrow = true;
            nextSphere.GetComponent<TriggerWaitingAnimation>().startTimer = true;
            gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
            firstTouch = false;
        }
    }
}