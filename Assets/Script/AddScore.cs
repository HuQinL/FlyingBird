using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private string first = "first";
    private string second = "second";
    private string third = "third";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            //加分
            GameServer.getSingleton().score++;
            AudioManager._instance.SetAudio(AudioClipType.score);
            if (GameServer.getSingleton().score > PlayerPrefs.GetInt(first))
            {
                PlayerPrefs.SetInt(first, (int)GameServer.getSingleton().score);
            }
            else if (GameServer.getSingleton().score > PlayerPrefs.GetInt(second) && GameServer.getSingleton().score != PlayerPrefs.GetInt(first))
            {
                PlayerPrefs.SetInt(second, (int)GameServer.getSingleton().score);
            }
            else if (GameServer.getSingleton().score > PlayerPrefs.GetInt(third) && GameServer.getSingleton().score != PlayerPrefs.GetInt(second))
            {
                PlayerPrefs.SetInt(third, (int)GameServer.getSingleton().score);
            }
        }
    }
}
