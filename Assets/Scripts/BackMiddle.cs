using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using UnityEngine;

public class BackMiddle : MonoBehaviour
{
    [SerializeField] private GameObject nextSphere;

    [SerializeField] private bool firstTouch;
    [SerializeField] private bool secondTouch;

    [SerializeField] private LineRenderer lineHorizontal;
    [SerializeField] private int durationToShowTheAxes = 4;
    [SerializeField] private GameObject[] axenGameObjects;
    [SerializeField] private GameObject[] linerenderers;
    [SerializeField] private GameObject controller;

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
            lineHorizontal.SetPosition(1, new Vector3(0, 0, 14));
            gameObject.GetComponent<TriggerWaitingAnimation>().startTimer = false;
            StartCoroutine(DissableAxesDelay());
        }
    }

    IEnumerator DissableAxesDelay()
    {
        yield return new WaitForSeconds(durationToShowTheAxes);
        foreach (var gameobject in axenGameObjects)
        {
            gameobject.GetComponent<SphereScrip>().ChangeColorToStart();
        }

        foreach (var linerender in linerenderers)
        {
            linerender.SetActive(false);
        }

        StartCoroutine(controller.GetComponent<TableAxe>().TableAxeCoroutine());
    }
}