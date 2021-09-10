using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//AI spawn 2 for Circuit 7

public class c7AItrig2 : MonoBehaviour
{
    public GameObject AIcar3;

    public void OnTriggerEnter(Collider other)
    {
        AIcar3.SetActive(true);
    }
}
