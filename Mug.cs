using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mug : MonoBehaviour {

    public GameObject mLiquid;
    public GameObject mLiquidMesh;
    public GameObject BlueBoar;
    public GameObject GoldBoar;
    public AudioSource splash, dino;
    public int count1 = 0;
    public int count2 = 0;
    GameObject cloneBlue = null;
    GameObject cloneGold = null;
    public int flag = 0;



    private int mSloshSpeed = 60;
    private int mRotateSpeed = 15;

    private int difference = 25;

    // Use this for initialization
    private void Start()
    {
       

    }


    // Update is called once per frame
    void Update () {
       
        Slosh();
       
        mLiquidMesh.transform.Rotate(Vector3.up * mRotateSpeed * Time.deltaTime, Space.Self);

	}

    private void Slosh()
    {
        Quaternion inverseRotation = Quaternion.Inverse(transform.localRotation);

        Vector3 firstRotation = Quaternion.RotateTowards(mLiquid.transform.localRotation, transform.localRotation, mSloshSpeed * Time.deltaTime).eulerAngles;
        Vector3 finalRotation = Quaternion.RotateTowards(mLiquid.transform.localRotation, transform.localRotation, mSloshSpeed * Time.deltaTime).eulerAngles;
        finalRotation.x = ClampRotationValue(firstRotation.x, difference);
        finalRotation.z = ClampRotationValue(firstRotation.z, difference);

        mLiquid.transform.localEulerAngles = finalRotation;


        if ((finalRotation.x > 16 && finalRotation.x < 180) || (finalRotation.x >180 && finalRotation.x < 340))
        {
            if(count1 < 1)
            {
                flag = 1;
                splash.Play();
                dino.Play();
                cloneBlue = Instantiate(BlueBoar, new Vector3(-100, 2, -147), new Quaternion(0, 20, 0, 10));
                BlueBoar.transform.localScale = new Vector3(3, 3, 3);
                
                count1 = 1;
            }
        }
        else
        {
            if (BlueBoar != null)
            {
                
                Destroy(cloneBlue);
                count1 = 0;
            }
        }

        if((finalRotation.z > 16 && finalRotation.z < 180) || (finalRotation.z > 180 && finalRotation.z < 340))
        {
            if (count2 < 1)
            {
                flag = 1;
                splash.Play();
                dino.Play();
                cloneGold = Instantiate(GoldBoar, new Vector3(-100, 2, -170), new Quaternion(0, 20, 0, 50));
                GoldBoar.transform.localScale = new Vector3(3, 3, 3);
                
                count2 = 1;
            }
        }
        else
        {
            if (GoldBoar != null)
            {
                
                Destroy(cloneGold);
                count2 = 0;
            }
        }

        if (((finalRotation.z < 16) || (finalRotation.z > 340)) && ((finalRotation.x < 16 ) || (finalRotation.x > 340)))
        {
            flag = 0;
        }
        /*else
        {
            flag = 0;
        }*/
        /*
        GameObject cloneGold = null;
        if (count < 1)
        {
            cloneGold = Instantiate(GoldBoar, new Vector3(-100, 2, -200), new Quaternion(0, 20, 0, 1));
            count = 1;
        }

        if (Input.GetKeyUp (KeyCode.E))
        {
            
            GoldBoar.transform.localScale = new Vector3(3, 3, 3);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(cloneGold);
        }*/

    }

    private void MoreSlosh()
    {

    }

    private float ClampRotationValue(float value, float difference)
    {
        float returnValue = 0.0f;

        if (value>180)
        {
            returnValue = Mathf.Clamp(value, 360 - difference, 360);
        }
        else
        {
            returnValue = Mathf.Clamp(value, 0, difference);
        }

        return returnValue;
    }
}
