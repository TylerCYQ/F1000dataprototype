using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Trigger script for fail condition for Circuit 5

public class failcon : MonoBehaviour
{
    public EndTriggerFront trigger;

    public void OnTriggerStay(Collider other)
    {
        trigger.settrigfail1 = true;
        trigger.settrigfail2 = true;
    }

    public void OnTriggerExit(Collider other)
    {
        trigger.settrigfail1 = false;
        trigger.settrigfail2 = false;
    }
}
