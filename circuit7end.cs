using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Conclusive Win Con for Circuit 7

public class circuit7end : MonoBehaviour
{
    public bool settrig1 = false;
    public bool settrig2 = false;

    public GameManager gManager;

    public void OnTriggerEnter(Collider other)
    {

        if (settrig1 == true && settrig2 == true)
            gManager.CompleteLevel();
    }
}
