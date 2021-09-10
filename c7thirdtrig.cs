using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trigger 3 for AICAR 3 in circuit 7

public class c7thirdtrig : MonoBehaviour
{
    public GameObject AI3;

    public void OnTriggerEnter(Collider other)
    {
        AI3.SetActive(false);

    }
}
