using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ChangeColor : MonoBehaviour
{
    private Material material;
    public bool red;
    public bool blue;

    Color _colorBlue = new Color(0, 0.08019246f, 0.1226415f);
    Color _colorRed = new Color(0.1981132f, 0.08305494f, 0.06479172f);

    void Start()
    {
        material = gameObject.GetComponent<MeshRenderer>().material;

        //Set the Bools
        red = Random.value < 0.5f;
        blue = red switch
        {
            true => false,
            false => true
        };

        switch (red)
        {
            case true:
                material.SetColor("_EmissionColor", _colorRed);
                break;
            case false:
                material.SetColor("_EmissionColor", _colorBlue);
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (blue && other.gameObject.name == "LHandCollider")
        {
            Debug.Log("blue Touch");
            DissableEmission();
        }
        else if (red && other.gameObject.name == "RHandCollider")
        {
            Debug.Log("red Touch");
            DissableEmission();
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    public void EnableEmission()
    {
        material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.None;
    }

    public void DissableEmission()
    {
        material.DisableKeyword("_EMISSION");
        material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack;
        material.SetColor("_EmissionColor", Color.black);
    }
}