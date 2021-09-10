using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//General MenuControl

public class MenuControl : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Practicemenu;
    public GameObject TestMenu;

    public void ButtonScene1()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void ButtonScene3()
    {
        SceneManager.LoadScene(3);
    }
    public void ButtonScene4()
    {
        SceneManager.LoadScene(4);
    }
    public void ButtonScene5()
    {
        SceneManager.LoadScene(5);
    }
    public void ButtonScene6()
    {
        SceneManager.LoadScene(6);
    }
    public void ButtonScene7()
    {
        SceneManager.LoadScene(7);
    }
    public void ButtonScene8()
    {
        SceneManager.LoadScene(8);
    }
    public void ButtonScene9()
    {
        SceneManager.LoadScene(9);
    }
    public void ButtonScene10()
    {
        SceneManager.LoadScene(10);
    }
    public void ButtonScene11()
    {
        SceneManager.LoadScene(11);
    }
    public void ButtonScene12()
    {
        SceneManager.LoadScene(12);
    }
    public void ButtonScene13()
    {
        SceneManager.LoadScene(13);
    }
    public void ButtonScene14()
    {
        SceneManager.LoadScene(14);
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void mainmenu()
    {
        Mainmenu.SetActive(true);
        Practicemenu.SetActive(false);
        TestMenu.SetActive(false);
    }

    public void pracmenu()
    {
        Mainmenu.SetActive(false);
        Practicemenu.SetActive(true);
        TestMenu.SetActive(false);
    }

    public void testmenu()
    {
        Mainmenu.SetActive(false);
        Practicemenu.SetActive(false);
        TestMenu.SetActive(true);
    }

}
