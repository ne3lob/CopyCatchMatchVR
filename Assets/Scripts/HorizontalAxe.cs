using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAxe : MonoBehaviour
{
    public GameObject RightSphere;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        RightSphere.GetComponent<SphereScrip>().isGrow = true;
    }
}