using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//General Simple End script used in Circut 1 and Circuit 2

public class Simpleend : MonoBehaviour
{
    public GameManager gManager;

    public void OnTriggerEnter(Collider other)
    {
            gManager.CompleteLevel();
            //Time.timeScale = 0;
    }
}
