using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enabledisable : MonoBehaviour {

	public GameObject gma;
	public GameObject gpa;

	bool trace = false;
	bool tracker = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void popUp()
	{
		if (tracker == false)
		{
			gma.SetActive (true);
			tracker = true;
		}
		else if( tracker == true)
		{
			gma.SetActive (false);
			tracker = false;
		}
	}

	public void popUp2()
	{
		if (trace == false)
		{
			gpa.SetActive (true);
			trace = true;
		}
		else if( trace == true)
		{
			gpa.SetActive (false);
			trace = false;
		}
	}

    public void playGame()
    {
        SceneManager.LoadScene("Leap Hands Demo (Desktop) 1");
    }
}
