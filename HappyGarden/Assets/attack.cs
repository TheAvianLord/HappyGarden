using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject enemy;
    public bool yesShoot = false;
	// Use this for initialization
	void Start ()
    {
        enemy = GameObject.FindWithTag("enemy");
	}

    // Update is called once per frame
    void Update()
    {
        if (yesShoot)
        {
            GameObject[] stars = GameObject.FindGameObjectsWithTag("star");
            if (stars.Length != 0)
            {
                for (int i = 0; i < stars.Length; i++)
                {
                    
                    GameObject star = stars[i];
                    StarBehavior starScript = star.GetComponent<StarBehavior>();
                    if (starScript.hit == true)
                    {
                        starScript.hit = false;
                        starScript.targetEnemy = true;
                    }
                }
                //star.transform.position = Vector3.MoveTowards(star.transform.position, enemy.transform.position, 0.005f);
                //Destroy(star, 5.0f);
                //Debug.Log("should be false");
            }
        }
    }

    //open hand
    public void shoot()
    {
        yesShoot = true;

    }

    //pointing
    public void activate()
    {
        yesShoot = false;
    }
}
