using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public GameObject projectile;
    public GameObject starter;
    float timer = 1f;
    public int enemyHealth = 100;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        float speed = 0.02f;
        //transform.position = Vector3.MoveTowards(transform.position, ship.transform.position, 0.0015f);
        Vector3 pos = Vector3.MoveTowards(transform.position, player.transform.position, 0.0015f);
        Vector3 spd = (pos - transform.position).normalized * speed;
        rb.velocity = spd;
        transform.LookAt(player.transform);


        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GameObject bullet = Instantiate(projectile, starter.transform.position, transform.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);
            Destroy(bullet, 10.0f);
            timer = 1f;

        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "star")
        {
            enemyHealth -= 10;
        }
    }
}
