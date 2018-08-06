using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float speed = 300;
    RectTransform _transform;

    public RectTransform tubes1;
    public RectTransform tubes2;
    private void Awake()
    {
        _transform = transform as RectTransform;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (_transform.anchoredPosition.x <= -800)
        {
            _transform.anchoredPosition = new Vector2(800, 0);
            tubes1.anchoredPosition = new Vector2(tubes1.anchoredPosition.x, Random.Range(-200, 300));
            tubes2.anchoredPosition = new Vector2(tubes2.anchoredPosition.x, Random.Range(-200, 300));
        }
    }
}
