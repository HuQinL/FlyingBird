using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject gameHomeBtn;
    public GameObject gameRestartBtn;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {

            if (!gameOver.activeSelf)
            {
                gameOver.SetActive(true);
                if (!gameHomeBtn.activeSelf)
                {
                    gameHomeBtn.SetActive(true);
                }
                if (!gameRestartBtn.activeSelf)
                {
                    gameRestartBtn.SetActive(true);
                }
                AudioManager._instance.SetAudio(AudioClipType.dead);
                AudioManager._instance.StopAudio();
            }

            MapMove map1 = GameObject.Find("MapMain").GetComponent<MapMove>();
            map1.enabled = false;
            MapMove map2 = GameObject.Find("MapMain1").GetComponent<MapMove>();
            map2.enabled = false;

            Rigidbody2D rigidbody2D = GameObject.Find("Player").GetComponent<Rigidbody2D>();
            Destroy(rigidbody2D);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
