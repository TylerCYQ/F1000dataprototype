using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//General AI spawn trigger for Circuit 7)

public class c7AItrig : MonoBehaviour
{
    public GameObject AIcar1;
    public GameObject AIcar2;

    public bool settrig1 = false;
    public bool settrig2 = false;

    public GameObject End;
    public GameObject Fail;

    public void OnTriggerEnter(Collider other)
    {
        AIcar1.SetActive(true);
        AIcar2.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        if(settrig1 == false || settrig2 == false)
        {
            End.SetActive(false);
            Fail.SetActive(true);
        }
    }
}
