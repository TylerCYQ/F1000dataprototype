using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//General Failcon for Circuit 7

public class c7failend : MonoBehaviour
{
    public GameManager gManager;

    public void OnTriggerEnter(Collider other)
    {
        gManager.FailLevel();
    }
}
