using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyIn : MonoBehaviour {

    public Transform start;

    public GameObject startPrompt;
    public GameObject countdown;
    float speed = 4;

    bool spaceEntered = false;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            countdown.GetComponent<space_countdown>().runTime = true;
            startPrompt.SetActive(false);
            spaceEntered = true;
        }
        if (speed > 0)
            speed = speed - (float)0.0002;

        float movement = speed * Time.deltaTime;

        if(spaceEntered)
            transform.position = Vector3.MoveTowards(transform.position, start.position, movement);
	}
}
