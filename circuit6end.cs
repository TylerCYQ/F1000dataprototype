using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Conclusive win for Circuit 6

public class circuit6end : MonoBehaviour
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
