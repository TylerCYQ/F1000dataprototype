using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Win condition for circuit 4 hillclimb

public class Wincon : MonoBehaviour
{
    public GameObject RedLight;

    public GameObject YellowLight;

    public GameObject GreenLight;

    public EndTrigger Trigger;
    

    float currentT = 0f;
    float countdownT = 4f;

    private void Start()
    {
        currentT = countdownT;
    }

    public void OnTriggerEnter(Collider other)
    {
        YellowLight.SetActive(false);
        RedLight.SetActive(true);
    }

    public void OnTriggerStay(Collider other)
    {
        currentT -= 1 * Time.deltaTime;

        if(currentT <= 0)
        {
            RedLight.SetActive(false);
            GreenLight.SetActive(true);

            Trigger.settrig = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(currentT > 0)
        {
            currentT = countdownT;
            YellowLight.SetActive(true);
            RedLight.SetActive(false);
        }
        
    }
}
