using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSound : MonoBehaviour {


    public AudioSource deflect;

    public TextMesh score;

    public int number = 0;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("test");
        deflect.Play();
        number += 10;
        string output = "Current Score: " + number.ToString();
        score.text =  output;
    }
}
