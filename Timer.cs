using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//General Timer for Test mode

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 180;
    public bool takingAway = false;

    public GameManager gManager;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "Time left: " + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        else
            if(takingAway == false && secondsLeft == 0)
        {
            gManager.FailLevel();
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "Time left: " + secondsLeft;
        takingAway = false;
    }

}
