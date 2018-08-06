using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIStart : MonoBehaviour
{

    public GameObject panel_Start;
    public GameObject panel_Ready;
    public GameObject panel_Ranking;
    public Toggle _audio;
    public AudioSource _audioSourceBG;
    public void ClickOpenPanel_Ready()
    {
        if (!panel_Ready.activeSelf)
        {
            panel_Ready.SetActive(true);
        }
        if (panel_Start.activeSelf)
        {
            panel_Start.SetActive(false);
        }
    }
    public void ClickOpenPanel_Ranking()
    {
        if (!panel_Ranking.activeSelf)
        {
            panel_Ranking.SetActive(true);
        }
        if (panel_Start.activeSelf)
        {
            panel_Start.SetActive(false);
        }
    }
    public void ClickOpenPanel_Exit()
    {
        Application.Quit();
    }
    public void ClickOpenPane1_Home()
    {
        if (!panel_Start.activeSelf)
        {
            panel_Start.SetActive(true);
        }
        if (panel_Ranking.activeSelf)
        {
            panel_Ranking.SetActive(false);
        }
    }

    public void ClickStartGame()
    {
        SceneManager.LoadScene("Main");
        GameServer.Stop();
    }
    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start()
    {
        panel_Start.SetActive(true);
        panel_Ready.SetActive(false);
        panel_Ranking.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameServer.getSingleton().isAudio = _audio.isOn;
        _audioSourceBG.mute = GameServer.getSingleton().isAudio;
    }
}
