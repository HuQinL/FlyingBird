using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{

    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = GameServer.getSingleton().score.ToString();
    }
    public void ClickHomeGame()
    {
        SceneManager.LoadScene("Start");
        GameServer.Stop();
    }
    public void ClickRestart()
    {
        SceneManager.LoadScene("Main");
        GameServer.Stop();
    }
}
