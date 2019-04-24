using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point2Station : MonoBehaviour {

    public bool point2 = false;


    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.name == "Point2Tether")
        {
            point2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        point2 = false;
    }
}
