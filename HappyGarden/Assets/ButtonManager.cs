using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
    public void button(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
