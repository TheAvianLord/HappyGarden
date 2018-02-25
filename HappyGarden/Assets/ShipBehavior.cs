using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehavior : MonoBehaviour
{
    public GameObject finger;
    public Rigidbody rb;
    public int health = 100;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
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
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bullet")
        {
            health -= 10;
        }
    }
}
