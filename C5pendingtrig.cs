using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Circuit 5 Trigger 1 for End/Win Condition 

public class C5pendingtrig : MonoBehaviour
{
    public GameObject greenlight;

    public EndTriggerFront Trigger;

    public void OnTriggerStay(Collider other)
    {
        //greenlight.SetActive(true);
        Trigger.settrigpend = false;
    }
    public void OnTriggerExit(Collider other)
    {
        Trigger.settrigpend = true;
    }
}
