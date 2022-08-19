using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LastSphere : MonoBehaviour
{
    public GameObject[] disableObjectInFirstPart;
    public GameObject leftAxe;

    private void OnTriggerEnter(Collider other)
    {
        foreach (var gameobj in disableObjectInFirstPart)
        {
            gameobj.GetComponent<SphereScrip>().ChangeColorToStart();
            gameobj.GetComponent<SphereScrip>().isDown = true;
        }

        gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
        //leftAxe.SetActive(true);
        leftAxe.GetComponent<SphereScrip>().isGrow = true;
    }
}