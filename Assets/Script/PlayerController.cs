using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 400;
    Rigidbody2D _rigidbody;

    
    // Use this for initialization
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody == null)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            AudioManager._instance.SetAudio(AudioClipType.click);
            _rigidbody.velocity = new Vector2(0, speed);
        }
        if (_rigidbody.velocity.y > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 60f);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -60f);
        }
    }
}
