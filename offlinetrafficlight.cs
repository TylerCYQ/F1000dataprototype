using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offlinetrafficlight : MonoBehaviour
{
    public float constantY;
    public float constantY1;

    public float timeRemainY;
    public float timeRemainY1;

    public GameObject YL;

    private void Start()
    {
        timeRemainY = constantY;
        timeRemainY1 = constantY1;   
    }

    // Update is called once per frame
    void Update()
    {     
        if(timeRemainY > 0)
        timeRemainY -= Time.deltaTime;
        YL.SetActive(true);
        if (timeRemainY < 0 && timeRemainY1 > 0)
        {
            YL.SetActive(false);
            timeRemainY1 -= Time.deltaTime;
        }
        else
        if(timeRemainY < 0 && timeRemainY1 < 0)
        {
            timeRemainY = constantY;
            timeRemainY1 = constantY1;
        }

           
    }
}
