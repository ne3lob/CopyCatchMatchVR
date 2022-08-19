using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSphere : MonoBehaviour
{
    public LineRenderer througtLine;
    public GameObject nextSphere;
    public GameObject backSphere;

    public bool firtsTouch;
    private bool secondTouch;
    public bool thirdTouch;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (firtsTouch)
        {
            nextSphere.GetComponent<SphereScrip>().isGrow = true;
            firtsTouch = false;
            secondTouch = true;
        }
        else if (secondTouch)
        {
            backSphere.GetComponent<SphereScrip>().isGrow = true;
            secondTouch = false;
        }
        else if (thirdTouch)
        {
            througtLine.SetPosition(1, new Vector3(0, 0, -14));
            thirdTouch = false;
        }
    }
}