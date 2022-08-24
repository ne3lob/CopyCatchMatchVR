using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererManager : MonoBehaviour
{
    public LineRenderer linePrefab;

    //transform of a hand to attach point B to
    public Transform endPointTransform;

    public bool isDrawLineInProgress;

    public int delayDuration = 5;
    private LineRenderer activeLine;
    [SerializeField] private bool isRightHand;
    //[SerializeField] private int delayBakeDuration = 1;

    private void Update()
    {
        if (activeLine)
        {
            activeLine.SetPosition(1, endPointTransform.position);
        }
    }

    public void StartDrawLine(Collider other)
    {
        activeLine = Instantiate(linePrefab);
        activeLine.SetPosition(0, other.gameObject.transform.position);
    }

    public void EndDrawLine(Collider other)
    {
        if (activeLine == null)
        {
            return;
        }

        activeLine.SetPosition(1, other.gameObject.transform.position);
        activeLine = null;
        StartCoroutine(EndDrawLineWithDelay());
        //BakeMeshLine();
    }

    private void BakeMeshLine()
    {
        Mesh mesh = new Mesh();
        activeLine.BakeMesh(mesh, true);
        activeLine.GetComponent<MeshCollider>().sharedMesh = mesh;
    }

    IEnumerator EndDrawLineWithDelay()
    {
        yield return new WaitForSeconds(delayDuration);
        isDrawLineInProgress = false;
    }

    // IEnumerator EndBakeWithDelay()
    // {
    //     yield return new WaitForSeconds(delayBakeDuration);
    //     isDrawLineInProgress = false;
    // }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter" + other.gameObject.name);
        if (isRightHand && other.GetComponent<SphereController>())
        {
            if (!isDrawLineInProgress)
            {
                isDrawLineInProgress = true;
                StartDrawLine(other);
            }
            else
            {
                EndDrawLine(other);
            }
        }
        //TODO: line
        else
        {
            if (!isRightHand && other.GetComponent<LineRenderer>())
            {
                Destroy(other.gameObject);
            }
        }
    }
}