using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopRightButton : MonoBehaviour
{
    public GameObject instructions;
    public void OnTriggerEnter()
    {
        instructions.SetActive(true);
    }

    public void OnTriggerLeave()
    {
        instructions.SetActive(false);
    }
}
