using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehavior: MonoBehaviour
{
    public GameObject ship;
    public GameObject enemy;
    public Rigidbody rb;
    public bool hit = false;
    public bool targetEnemy = false;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        enemy = GameObject.FindWithTag("enemy");
        ship = GameObject.FindWithTag("follower");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (hit)
        {
            //float speed = 0.5f;
            transform.position = Vector3.MoveTowards(transform.position, ship.transform.position, 0.0010f);
            //Vector3 pos = Vector3.MoveTowards(transform.position, ship.transform.position, 0.0015f);
           // Vector3 spd = (pos - transform.position).normalized * speed;
           // rb.velocity = spd;
        }

        if (targetEnemy)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, 0.005f);
            Destroy(gameObject, 2.0f);
        }
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "PrototypeZero")
        {
            hit = true;
        }

        else
        {
            //Destroy(gameObject);
        }
        
    }
}


