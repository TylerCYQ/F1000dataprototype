using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//GameManager 

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject levelCompleteUI;

    public GameObject levelFailUI;

    public GameObject Car;

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
    }

    public void FailLevel()
    {
        levelFailUI.SetActive(true);
        Car.SetActive(false);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

