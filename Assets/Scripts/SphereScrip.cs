using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScrip : MonoBehaviour
{
    public Vector3 InitialScale = new Vector3(0, 0, 0);
    public Vector3 FinalScale = new Vector3(0.15f, 0.15f, 0.15f);
    public float TimeScaleUp = 1;
    public float TimeScaleDown = 0.5f;
    public bool isGrow;
    public bool isDown;
    private Material material;

    private Color _blackColorImmisive = new Color(0.1037736f, 0.1037736f, 0.1037736f);
    private Color _whiteColorEmmisive = new Color(0.8962264f, 0.8962264f, 0.8962264f);
    private float timeChangeImmisivel = 1f;

    private void Awake()
    {
        gameObject.transform.localScale = InitialScale;
    }

    // Start is called before the first frame update
    void Start()
    {
        material = gameObject.GetComponent<MeshRenderer>().material;
    }

    public void ChangeColorToWhite()
    {
        //material.SetColor("_EmissionColor", _whiteColor);
        material.SetColor("_EmissionColor",
            Color.Lerp(_whiteColorEmmisive, _blackColorImmisive, Time.deltaTime / timeChangeImmisivel));
    }

    public void ChangeColorToStart()
    {
        //material.SetColor("_EmissionColor", _whiteColor);
        material.SetColor("_EmissionColor", _blackColorImmisive);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrow)
        {
            StartCoroutine(LerpUp());
            isGrow = false;
        }
        else if (isDown)
        {
            StartCoroutine(LerpDown());
            isDown = false;
        }
    }

    public IEnumerator LerpUp()
    {
        float progress = 0;

        while (progress <= 1)
        {
            transform.localScale = Vector3.Lerp(InitialScale, FinalScale, progress);
            progress += Time.deltaTime * TimeScaleUp;
            yield return null;
        }

        transform.localScale = FinalScale;
    }

    IEnumerator LerpDown()
    {
        float progress = 0;

        while (progress <= 1)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, InitialScale, progress);
            progress += Time.deltaTime * TimeScaleDown;
            yield return null;
        }

        transform.localScale = InitialScale;
    }
}