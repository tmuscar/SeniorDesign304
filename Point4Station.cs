using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point4Station : MonoBehaviour {


    public bool point4 = false;


    void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.name == "Point4Tether")
        {
            point4 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        point4 = false;
    }
}
