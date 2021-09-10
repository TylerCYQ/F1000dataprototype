using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Circuit 6 Trigger 2 for AICAR2

public class secondtrig : MonoBehaviour
{
    public circuit6end Trigger;
    public C6jumpstart Trigger1;

    public GameObject Car2;

    public void OnTriggerEnter(Collider other)
    {
        Trigger.settrig2 = true;
        Trigger1.jumptrig2 = false;
        Car2.SetActive(false);
    }
}
