using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jumpstart checker for Circuit 6

public class C6jumpstart : MonoBehaviour
{
    public bool jumptrig1 = true;
    public bool jumptrig2 = true;

    public GameObject EndTrig;
    public GameObject FailTrig;

    public void OnTriggerExit(Collider other)
    {
       if(jumptrig1 == true || jumptrig2 == true)
        {
            EndTrig.SetActive(false);
            FailTrig.SetActive(true);
        }
    }

}
