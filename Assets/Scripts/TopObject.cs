using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopObject : MonoBehaviour
{
    public LineRenderer lineVertical;
    public GameObject fowardObject;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        lineVertical.SetPosition(1, new Vector3(0, -17, 0));
        fowardObject.GetComponent<SphereScrip>().isGrow = true;
        fowardObject.GetComponent<TriggerWaitingAnimation>().startTimer = true;
        gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
    }
}