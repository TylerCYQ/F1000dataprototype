using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trigger 1 for AICAR 1 in circuit 7

public class c7firsttrig : MonoBehaviour
{
    public circuit7end Trigger;

    public c7AItrig Trigger1;

    public GameObject AI2;

    public void OnTriggerEnter(Collider other)
    {
        Trigger.settrig1 = true;
        Trigger1.settrig1 = true;
        AI2.SetActive(false);

    }
}
