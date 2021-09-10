using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redlightscript : MonoBehaviour
{
    public GameObject RL;
    public GameObject cube1;

    // Update is called once per frame
    void Update()
    {
        if (RL.activeSelf == true)
        {
            cube1.SetActive(true);

        }
        if (RL.activeSelf == false)
        {
            cube1.SetActive(false);
        }
    }
}
