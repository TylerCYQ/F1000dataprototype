using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Circuit 6 first trigger for AICAR1

public class firsttrig : MonoBehaviour
{
    public circuit6end Trigger;

    public C6jumpstart Trigger1;

    public GameObject Car1;

    public void OnTriggerEnter(Collider other)
    {
        Trigger.settrig1 = true;
        Trigger1.jumptrig1 = false;
        Car1.SetActive(false);
    }
}
