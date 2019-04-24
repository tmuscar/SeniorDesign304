using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print_Boom : MonoBehaviour {
    public KeyCode input;
    public GameObject explosionVFX;
    // Use this for initialization
    void Start () {
       
    }
	
    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(2);

    }
	// Update is called once per frame
	void Update () {
        string output = "BOOM";
        string clear = "";
        if (Input.GetKeyDown(input))
        {

            GetComponent<TextMesh>().text = output;
            Instantiate(explosionVFX, transform.position, transform.rotation);
        }
        if (Input.GetKeyUp(input))
        {
            GetComponent<TextMesh>().text = clear;
        }
    }
}
