using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BallController : MonoBehaviour
{
    public GameObject[] firstPartBalls;
    public GameObject[] firstPartBallsUser;
    public int delayDurationStart = 5;
    private SphereScrip SphereScrip;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartFirstPartWithDelay());
    }

    IEnumerator StartFirstPartWithDelay()
    {
        yield return new WaitForSeconds(delayDurationStart);
        //firstPartBalls[0].SetActive(true);
        firstPartBalls[0].GetComponent<SphereScrip>().isGrow = true;
        firstPartBallsUser[0].GetComponent<SphereScrip>().isGrow = true;
    }

    // Update is called once per frame
    void Update()
    {
    }
}