using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trigger 2 for AICAR 2 in circuit 7

public class c7secondtrig : MonoBehaviour
{
    public circuit7end Trigger;

    public c7AItrig Trigger1;

    public GameObject AI1;

    public void OnTriggerEnter(Collider other)
    {
        Trigger.settrig2 = true;
        Trigger1.settrig2 = true;
        AI1.SetActive(false);
    }
}
