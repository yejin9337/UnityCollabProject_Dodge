using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 5f;
    public float ActiveTime = 5f;

    private float _elapsedTime = 0f;
    void Update()
    {
        transform.Translate(0f, 0f, Speed * Time.deltaTime);

        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= ActiveTime)
        {
            _elapsedTime = 0f;

            gameObject.SetActive(false);
        }
    }
}
