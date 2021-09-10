using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondarytrafficscript : MonoBehaviour
{
    public GameObject RL;
    public GameObject YL;
    public GameObject GL;

    public GameObject RL1;
    public GameObject YL1;
    public GameObject GL1;

    public float constantT1;
    public float constantT2;

    public float TimeRemain1;
    public float TimeRemain2;

    void Start()
    {
        TimeRemain1 = constantT1;
        TimeRemain2 = constantT2;
    }

    // Update is called once per frame
    void Update()
    {   
        if(RL.activeSelf == true)
        {
            GL1.SetActive(true);
            RL1.SetActive(false);

            TimeRemain1 -= Time.deltaTime;
            
            
        }else
            if (TimeRemain1 < 0 && RL.activeSelf == true)
            {
            GL1.SetActive(false);
            YL1.SetActive(true);

            TimeRemain2 -= Time.deltaTime;
            
            }else
                if (TimeRemain2 < 0)
                {
                
                YL1.SetActive(false);
                RL1.SetActive(true);

                }
                    else
                    {

                    TimeRemain1 = constantT1;
                    TimeRemain2 = constantT2;

                    }
    }
}
