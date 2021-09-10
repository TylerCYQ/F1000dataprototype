using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//AI spawn for Circuit 6

public class c6Aicontrol : MonoBehaviour
{
    public GameObject AI1;

    public void OnTriggerEnter(Collider other)
    {
        AI1.SetActive(true);
    }
}
