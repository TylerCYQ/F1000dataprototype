using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Circuit 3 threepoint end script

public class threepturnend : MonoBehaviour
{
    public GameManager gManager;

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "front")
        {
            gManager.CompleteLevel();
        }
    }
}
