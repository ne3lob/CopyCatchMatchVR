using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpRight : MonoBehaviour
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
            firstTouch = false;
        }
    }
}