using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableAxe : MonoBehaviour
{
    public GameObject[] tableAxes;
    public bool EmissiveTableAxes;
    public float timeBetween = 1f;
    public int countActiveObject;


    // Update is called once per frame
    void Update()
    {
        if (EmissiveTableAxes && countActiveObject < 5)
        {
            TableAxesEnable();
        }
    }

    public void TableAxesEnable()
    {
        StartCoroutine(Count());
    }

    public IEnumerator Count()
    {
        foreach (GameObject tableAxe in tableAxes)
        {
            tableAxe.SetActive(true);
            yield return
                new WaitForSeconds(timeBetween);
            countActiveObject++;
        }
    }
}