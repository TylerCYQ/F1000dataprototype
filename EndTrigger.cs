using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//General End Game Trigger 

public class EndTrigger : MonoBehaviour
{
    public GameManager gManager;

    public bool settrig = false;

    public void OnTriggerEnter(Collider other)
    {

        if(settrig == true)
        gManager.CompleteLevel();
    }

}
