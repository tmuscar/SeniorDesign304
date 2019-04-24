using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mug_Angles : MonoBehaviour {

    public GameObject mug;
    private TextMesh testMesh;
    string converted;
    Vector3 val;
	// Use this for initialization
	void Start () {
        //Vector3 val = mug.transform.localEulerAngles;
        //string converted = val.ToString();
        //testMesh = GetComponent<TextMesh>();

        //Vector3 val = mug.transform.localEulerAngles;
        //string converted = val.ToString();
        //GetComponent<TextMesh>().text = converted;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 val = mug.transform.localEulerAngles;
        
        if(val.x < 360 && val.x > 180)
        {
            val.x = val.x - 360;
        }
        if(val.z < 360 && val.z > 180)
        {
            val.z = val.z - 360;
        }

        string valx_string = val.x.ToString("0.0");
        string valz_string = val.z.ToString("0.0");
        string output = "X rotation: " + valx_string + "\nZ rotation: " + valz_string;
        GetComponent<TextMesh>().text = output;
        //testMesh.text = "Changed";
    }
}
