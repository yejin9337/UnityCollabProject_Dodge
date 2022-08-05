using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotate : MonoBehaviour
{
    public GameObject Map;
    public GameObject Chickens;

    public float RotationSpeed;
    void Update()
    {
        Map.transform.Rotate(0f, -RotationSpeed * Time.deltaTime, 0f);
        Chickens.transform.Rotate(0f, RotationSpeed * 0.5f * Time.deltaTime, 0f);
    }
}
