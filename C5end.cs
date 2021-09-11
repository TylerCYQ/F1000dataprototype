using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Conclusive Win Condition for Circuit 5

public class C5end : MonoBehaviour
{
    public GameManager gManager;

    public bool settrigpend = false;
    public bool settrigfail1 = false;
    public bool settrigfail2 = false;

    public GameObject greenlight;
    public GameObject redlight;
    public GameObject yellowlight;

    float currentT = 0f;
    float countdownT = 10f;

    private void Start()
    {
        currentT = countdownT;
    }

    public void OnTriggerStay(Collider other)
    {
        if (settrigfail1 == false && settrigfail2 == false && settrigpend == true)
        {
            greenlight.SetActive(false);
            yellowlight.SetActive(false);
            redlight.SetActive(true);
            currentT -= 1 * Time.deltaTime;
            if (currentT <= 0)
                gManager.CompleteLevel();
        }
        else
            if (settrigpend == false)
        {
            greenlight.SetActive(true);
        }
        else
            if (settrigpend == true && settrigfail1 == true || settrigfail2 == true)
        {
            yellowlight.SetActive(true);
            greenlight.SetActive(false);
        }
        
    }
}
