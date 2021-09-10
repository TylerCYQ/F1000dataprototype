using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float constantR;
    public float constantY;
    public float constantG;

    public float timeRemainR;
    public float timeRemainY;
    public float timeRemainG;

    public GameObject RL;
    public GameObject YL;
    public GameObject GL;

    private void Start()
    {
        timeRemainR = constantR;
        timeRemainY = constantY;
        timeRemainG = constantG;
    }


    // Update is called once per frame
    void Update()
    {

        if (timeRemainR > 0 && timeRemainY == constantY && timeRemainG == constantG)
        {
            timeRemainR -= Time.deltaTime;
            RL.SetActive(true);
            YL.SetActive(false);
            GL.SetActive(false);
        }
        else
            if (timeRemainR < 0 && timeRemainY == constantY && timeRemainG > 0)
        {
            timeRemainG -= Time.deltaTime;
            RL.SetActive(false);
            YL.SetActive(false);
            GL.SetActive(true);
        }
        else
        if (timeRemainR < 0 && timeRemainY > 0 && timeRemainG < 0)
        {
            timeRemainY -= Time.deltaTime;
            RL.SetActive(false);
            YL.SetActive(true);
            GL.SetActive(false);
        }
        else
        {
            timeRemainR = constantR;
            timeRemainY = constantY;
            timeRemainG = constantG;
        }
    }
}
