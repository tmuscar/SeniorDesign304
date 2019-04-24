using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonEffect : MonoBehaviour
{
    public KeyCode input;
    public GameObject explosionVFX;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(input))
        {
            Instantiate(explosionVFX, transform.position, transform.rotation);
        }
    }
}
