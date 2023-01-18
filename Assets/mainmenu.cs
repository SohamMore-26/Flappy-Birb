using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public AudioSource clicksound;

    public void exitbutton()
    {
        clicksound.Play();
        Application.Quit();
        Debug.Log("exited");
    }

    public void startgame()
    {
        clicksound.Play();
        SceneManager.LoadScene("game");
    }

    public void startcredit()
    {
        clicksound.Play();
        SceneManager.LoadScene("credits");

    }

    public void startmenu()
    {
        clicksound.Play();
        SceneManager.LoadScene("menu");
    }

    public void options()
    {
        clicksound.Play();
        SceneManager.LoadScene("options");
    }

    public void clicksoundeffect()
    {
        clicksound.Play();
    }



}
