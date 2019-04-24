using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class Rotation : MonoBehaviour {

    public GameObject point1Cube, point2Cube, point3Cube, point4Cube, user;

    public AudioSource success;

    public GameObject cylinder;

    public GameObject gameOver;

    private int count = 0;

    bool stopRotation = false;
    // Update is called once per frame

    float temporaryTime;
    float counter;
    float timeLapse = (float)0.5;
    float speed;

    void Start()
    {
        speed = 60;
        counter =0;
        temporaryTime =200;

    }
    void Update () {
        //transform.Rotate(0,1,0);
        counter += (float)0.1;
        if (!(point1Cube.GetComponent<Point1Station>().point1 && point2Cube.GetComponent<Point2Station>().point2 &&
            point3Cube.GetComponent<Point3Station>().point3 && point4Cube.GetComponent<Point4Station>().point4) && !stopRotation)
        {

            if ((400 > counter) && (counter > temporaryTime))
            {
                speed = 30;
            }
            if (counter > 400)
            {
                speed = 10;
            }

            transform.Rotate(speed * Vector3.up * Time.deltaTime);
        }
        else
        {
            stopRotation = true;
            user.transform.SetParent(gameObject.transform);
        }

        if (stopRotation)
        {
            if (success.isPlaying == false && count < 1)
            {
                count++;
                success.Play();
            }
            cylinder.GetComponent<space_countdown>().runTime = false;
            transform.Rotate(0 * Vector3.up * Time.deltaTime);
            gameOver.SetActive(true);

        }
    }

}
