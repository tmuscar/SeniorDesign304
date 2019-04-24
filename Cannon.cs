using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    public KeyCode FireKey;
    public AudioSource sound;
    public float projectileSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(FireKey))
        {
            GameObject fireball = Instantiate(projectile, transform) as GameObject;
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward* projectileSpeed;
            sound.Play();

            

            

        }
    }
}
