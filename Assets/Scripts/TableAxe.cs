using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableAxe : MonoBehaviour
{
    public GameObject[] tableAxes;
    [SerializeField] private int firstStartAfter;


    public IEnumerator TableAxeCoroutine()
    {
        yield return new WaitForSeconds(firstStartAfter);
        for (int i = 0; i < tableAxes.Length; i++)
        {
            if (i % 2 == 0)
            {
                tableAxes[i].GetComponent<SphereScrip>().ChangeColorToWhite();
            }
            else
            {
                tableAxes[i].GetComponent<SphereScrip>().ChangeColorToWhite();
                StartCoroutine(tableAxes[i].GetComponent<SphereScrip>().LerpUp());
            }

            yield return new WaitForSeconds(1f);
        }
    }
}