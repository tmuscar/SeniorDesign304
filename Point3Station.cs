using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point3Station : MonoBehaviour {


    public bool point3 = false;



    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.name == "Point3Tether")
        {
            point3 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        point3 = false;
    }
}
