using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class space_countdown : MonoBehaviour
{
    public int timeLeft = 30; //Seconds Overall
    public TextMesh countdown; //UI Text Object
    public GameObject countObject;
    private int count = 0;
    private int count1 = 0;
    public GameObject meteor1, meteor2, meteor3, meteor4, meteor5, meteor6, meteor7, meteor8, cylinder;
    public Transform explosion1, explosion2, explosion3, explosion4;
    public GameObject ISS;
    public AudioSource explosion, arrival;
    public AudioSource connecting, failure;
    public GameObject explosionVFX;
    public Transform start;

    public bool runTime = false;
    public bool flag = false;

    void Start()
    {
        connecting.Play();
        Time.timeScale = 1; //Just making sure that the timeScale is right
        StartCoroutine("LoseTime");
        countObject.SetActive(false);
        
    }
    void Update()
    {
        
        if (transform.position.z == start.position.z)
        {
            if (arrival.isPlaying == false && count1 < 1)
            {
                runTime = true;
                StartCoroutine("LoseTime");
                
                count1++;
                arrival.Play();
            }
            
            countObject.SetActive(true);
            
        }
        if (timeLeft >= 0)
        {
            RotateMeteors();
            countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
        }
        else
        {
            
            TriggerExplosion();
            StopCoroutine("LoseTime");
        }
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {

            while (runTime)
            {
                yield return new WaitForSeconds(1);
                timeLeft--;
            }
        
    }

    void TriggerExplosion()
    {
        float speed = (float)0.5;
        if (failure.isPlaying == false && count < 1)
        {
            count++;
            failure.Play();
        }
        else
        {
            RotateMeteors();
        }
        if (failure.isPlaying == false)
        {
            meteor1.transform.position = Vector3.MoveTowards(meteor1.transform.position, explosion1.position, speed);
            meteor2.transform.position = Vector3.MoveTowards(meteor2.transform.position, explosion2.position, speed);
            meteor3.transform.position = Vector3.MoveTowards(meteor3.transform.position, explosion3.position, speed);
            meteor4.transform.position = Vector3.MoveTowards(meteor4.transform.position, explosion4.position, speed);
        }

        if(((meteor1.transform.position == explosion1.position) || (meteor2.transform.position == explosion2.position) ||
            (meteor3.transform.position == explosion3.position) || (meteor4.transform.position == explosion4.position)) && !flag)
        {
            explosion.Play();
            Instantiate(explosionVFX, explosion1.position, explosion1.rotation);
            Instantiate(explosionVFX, explosion2.position, explosion1.rotation);
            Instantiate(explosionVFX, explosion3.position, explosion1.rotation);
            Instantiate(explosionVFX, explosion4.position, explosion1.rotation);
            ISS.SetActive(false);
            meteor1.SetActive(false);
            meteor2.SetActive(false);
            meteor3.SetActive(false);
            meteor4.SetActive(false);
            cylinder.SetActive(false);

            flag = true;
        }

    }


    void RotateMeteors()
    {
        
        meteor1.transform.RotateAround(ISS.transform.position, Vector3.up, 25 * Time.deltaTime);
        meteor2.transform.RotateAround(ISS.transform.position, Vector3.up, 10 * Time.deltaTime);
        meteor3.transform.RotateAround(ISS.transform.position, Vector3.up, 15 * Time.deltaTime);
        meteor4.transform.RotateAround(ISS.transform.position, Vector3.up, 20 * Time.deltaTime);
        meteor5.transform.RotateAround(ISS.transform.position, Vector3.right, 8 * Time.deltaTime);
        meteor6.transform.RotateAround(ISS.transform.position, Vector3.up, 30 * Time.deltaTime);
        meteor7.transform.RotateAround(ISS.transform.position, Vector3.right, 3 * Time.deltaTime);
        meteor8.transform.RotateAround(ISS.transform.position, Vector3.up, 25 * Time.deltaTime);
    }
}


