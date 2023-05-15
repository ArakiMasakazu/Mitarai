using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] GameObject _objectPrefab;
    [SerializeField] float _interval = 1.0f;
    [SerializeField] float _spawnDistance = 20.0f;
    [SerializeField] float _spawnHeight = 3.0f;

    float _elapsedTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime > _interval)
        {
            _elapsedTime -= _interval;
            Vector3 spawnPosition = transform.position + Vector3.forward * _spawnDistance + Vector3.right * Random.Range(-3.0f, 3.0f) + Vector3.up * _spawnHeight;
            Instantiate(_objectPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
