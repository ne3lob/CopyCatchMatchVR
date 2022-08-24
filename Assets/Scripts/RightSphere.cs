using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RightSphere : MonoBehaviour
{
    public LineRenderer lineHorizontal;
    public GameObject bottomObject;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        lineHorizontal.SetPosition(1, new Vector3(14, 0, 0));
        bottomObject.GetComponent<SphereScrip>().isGrow = true;
        bottomObject.GetComponent<TriggerWaitingAnimation>().startTimer = true;
        gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
    }
}