using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]

    private int maxHealth;

    private int currentHealth;

    public event Action<float> OnHealthPctChanged = delegate { };

    public AudioSource sound, dead;

    public TextMesh gameover;

    public GameObject healthBar;

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void ModifyHealth(int amount)
    {
        sound.Play();
        currentHealth += amount;

        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);
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

    void OnTriggerEnter(Collider other)
    {
        string output = "Good Game\nPress Q to Return\nTo Main Menu";

        ModifyHealth(-10);

        Debug.Log(currentHealth);

        if (currentHealth <= 0)
        {
            dead.Play();
            healthBar.SetActive(false);
            GetComponentInChildren<TextMesh>().text = output;
        }
        
    }

}
