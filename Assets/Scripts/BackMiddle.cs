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
    [SerializeField] private int delayDuration = 4;
    [SerializeField] private GameObject[] axenGameObjects;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (firstTouch)
        {
            gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
            nextSphere.GetComponent<SphereScrip>().isGrow = true;
            secondTouch = true;
            firstTouch = false;
        }
        else if (secondTouch)
        {
            gameObject.GetComponent<SphereScrip>().ChangeColorToWhite();
            lineHorizontal.SetPosition(1, new Vector3(0, 0, 14));
            StartCoroutine(DissableAxesDelay());
        }
    }

    IEnumerator DissableAxesDelay()
    {
        yield return new WaitForSeconds(delayDuration);
        foreach (var gameobject in axenGameObjects)
        {
            gameobject.SetActive(false);
            gameobject.GetComponent<SphereScrip>().ChangeColorToStart();
        }
    }
}