using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameServer
{

    private static GameServer _instance;
    public static GameServer getSingleton()
    {
        if (_instance == null)
        {
            _instance = new GameServer();
        }
        return _instance;
    }
    public float score;
    public float maxScore;
    public bool isAudio;
    private GameServer()
    {
        score = 0;
        maxScore = 0;
        isAudio = false;
    }
    public static void Stop()
    {
        if (_instance != null)
        {
            _instance = new GameServer();
        }
    }
}
