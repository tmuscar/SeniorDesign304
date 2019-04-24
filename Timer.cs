using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]

    private int maxHealth;

    private double currentHealth;

    public GameObject tracker;

    public GameObject healthBar, textObject, rotation;

    public event Action<float> OnHealthPctChanged = delegate { };

    public int startFlag = 0;

    public TextMesh start;


    private void OnEnable()
    {
        currentHealth = 0;
        healthBar.SetActive(false);
        
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            healthBar.SetActive(true);
            textObject.SetActive(false);
            rotation.SetActive(true);
            startFlag = 1;
            
        }

        if (startFlag == 1)
        {

            if (tracker.GetComponent<Mug>().flag == 1)
                currentHealth += -0.1;
            else
                currentHealth += 0.1;

            float currentHealthPct = (float)currentHealth / (float)maxHealth;
            OnHealthPctChanged(currentHealthPct);
            if(currentHealthPct == 1)
            {
                healthBar.SetActive(false);
                rotation.SetActive(false);
                //GetComponentInChildren<TextMesh>().text = "Well Done";
                start.text = "Well Done!\nPress Q to Return\nTo Main Menu";
                textObject.SetActive(true);
                currentHealth = 0;
                OnHealthPctChanged(0);
                startFlag = 0;
            }
        }
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ModifyHealth(-10);

            Debug.Log(currentHealth);

            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
            
    }*/

    /*void OnTriggerEnter(Collider other)
    {
        string output = "GG";

        ModifyHealth(-10);

        Debug.Log(currentHealth);

        if (currentHealth <= 0)
        {
            dead.Play();
            GetComponentInChildren<TextMesh>().text = output;
        }

    }*/

}
