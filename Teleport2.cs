using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour {

    public Transform tower;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.position = tower.position;
        }
    }


    public void Top_of_Tower(Transform top)
    {
        transform.position = top.position;
        Debug.Log("Hello");
    }

    public void Inside_Castle(Transform inside)
    {
        transform.position = inside.position;
    }
}
