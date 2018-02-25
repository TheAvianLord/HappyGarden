using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipBehavior : MonoBehaviour
{
    public Image healthBar;
    public float maxHealth = 100;
    public GameObject finger;
    public Rigidbody rb;
    public float health = 100;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        health = maxHealth;
    }
	
	// Update is called once per frame
	void Update ()
    {
       // Debug.Log(health);
        if (finger != null)
        {

            float speed = 0.06f;
            //transform.position = Vector3.MoveTowards(transform.position, ship.transform.position, 0.0015f);
            Vector3 pos = Vector3.MoveTowards(transform.position, finger.transform.position, 0.0015f);
            Vector3 spd = (pos - transform.position).normalized * speed;
            rb.velocity = spd;
            transform.LookAt(finger.transform);
        }

        healthBar.fillAmount = health / maxHealth;
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {
            health -= 10;
            if (health <= 0)
            {
                SceneManager.LoadScene("Lose");
            }
        }
    }
}
