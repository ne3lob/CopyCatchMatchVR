using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImproveFPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {
        OVRPlugin.fixedFoveatedRenderingLevel = OVRPlugin.FixedFoveatedRenderingLevel.HighTop;
    }
}