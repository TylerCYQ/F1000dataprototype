using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redcollider : MonoBehaviour
{
    public GameManager gManager;

    public void OnTriggerEnter(Collider other)
    {
        gManager.FailLevel();
    }
}
