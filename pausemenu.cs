using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//General Pause Menu

public class pausemenu : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                gamePaused = false;
                Cursor.visible = false;
                pauseMenu.SetActive(false);
            }
        }
    }
}
