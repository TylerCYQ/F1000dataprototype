using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//General Fail con for Circuit 6

public class c6failend : MonoBehaviour
{
    public GameManager gManager;

    public void OnTriggerEnter(Collider other)
    {
            gManager.FailLevel();
    }
}
