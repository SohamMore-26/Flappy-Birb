using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pausegameui;

    public static bool GameisPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chpause()
    {
        if (GameisPaused == true)
        {
            resume();
        }
        else
        {
            pause();
        }
    }

   
    public void resume()
    {
        pausegameui.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void pause()
    {
        pausegameui.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void mainmnu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
    }
}
