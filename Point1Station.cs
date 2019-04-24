using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point1Station : MonoBehaviour {

    
    public bool point1 = false;


    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.name == "Point1Tether")
        {
            point1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        point1 = false;
    }
}
