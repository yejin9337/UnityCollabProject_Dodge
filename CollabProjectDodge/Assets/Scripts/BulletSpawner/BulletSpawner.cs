using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    public int Counts = 30;

    private Vector3 _spawnPosition;
    private GameObject[] _bullets;
    private void Awake()
    {
        _bullets = new GameObject[Counts];
        _spawnPosition = transform.position;
        for(int i = 0; i < Counts; ++i)
        {
            _bullets[i] = Instantiate(BulletPrefab, _spawnPosition, Quaternion.identity);
            _bullets[i].transform.SetParent(transform);
            _bullets[i].SetActive(false);
        }
    }

    private float _elapsedTime = 0f;
    private float _nextSpawnCooltime = 1f;
    private int _count = 0;
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime < _nextSpawnCooltime)
        {
            return;
        }
        _elapsedTime = 0f;
        _nextSpawnCooltime = Random.Range(1f, 3f);

        if (_count >= Counts)
        {
            _count = 0;
        }

        _bullets[_count].transform.position = _spawnPosition;
        _bullets[_count].transform.LookAt(Player);
        _bullets[_count].SetActive(true);
        ++_count;
    }
}
