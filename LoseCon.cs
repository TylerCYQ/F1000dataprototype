using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Conclusive Lose Condition for Circuit 7

public class LoseCon : MonoBehaviour
{
    public GameManager gManager;

    public GameObject AIcar1;
    public GameObject AIcar2;
    public GameObject AIcar3;

    public void OnTriggerEnter(Collider other)
    {
        gManager.FailLevel();
        AIcar1.SetActive(false);
        AIcar2.SetActive(false);
        AIcar3.SetActive(false);

    }

}
