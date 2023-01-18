using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class logicsricpt : MonoBehaviour
{
    public int playerscore;
    public TMP_Text scoretext;
    public GameObject gameoverscreen;
    public TMP_Text highscore;
    public TMP_Text cointxt;
    public AudioSource clicksound;
    public static int coincount ;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
        coincount = PlayerPrefs.GetInt("CoinCount",0);
    }

    private void Update()
    {
        cointxt.text = coincount.ToString();
    }

    [ContextMenu("increase score")]
    public void addscore(int scoretoadd)
    {
        playerscore = playerscore + scoretoadd;
        scoretext.text = playerscore.ToString();

        if (playerscore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", playerscore);
            highscore.text = playerscore.ToString();
        }


        Debug.Log("scoreadded");
    
    }

    public void restartgame()
    {
        clicksound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }


    public void coinadd(int cointoadd)
    {
        coincount = coincount + cointoadd;
        PlayerPrefs.SetInt("CoinCount", coincount);    
    }

}
