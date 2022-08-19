using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController: MonoBehaviour
{
    public LineRenderer linePrefab;
    private LineRenderer activeLine;
    private HandDrawController activeHand;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeLine)
        {
            activeLine.SetPosition(1, activeHand.transform.position);
        }
    }


    private Collider handCollider;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter" +  other.gameObject.name);

        activeHand = other.GetComponent<HandDrawController>();
        if (other.gameObject.name == "RHandCollider" && !activeHand.isDrawLineActive)
        {
            activeHand.isDrawLineActive = true;
            //handCollider = other;
            StartDrawLine();
            //Debug.Log("blue Touch");
            
        }
        else
        {
            FinishDrawLine();
            
        }
       
    }

    private void FinishDrawLine()
    {
        Debug.Log("FInish draw line");
        
        activeHand.activeLine.SetPosition(1, this.gameObject.transform.position);
        activeHand.isDrawLineActive = false;
        activeHand.activeLine = null;
    }

    private void StartDrawLine()
    { 
        Debug.Log("Start draw line");
        activeLine =  Instantiate(linePrefab);
        activeHand.activeLine = activeLine;
        activeLine.SetPosition(0, this.gameObject.transform.position);

    }
    
    
}
