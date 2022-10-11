using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private GameObject _cube;

    private float _countDown = 0.0f;

    public void SetTimeSpawn(float value)
    {
        _timeSpawn = value; 
    }

    private void Update()
    {
        if (_countDown < 0)
        {
            StartCoroutine(Spawn());
            _countDown = _timeSpawn;
            return;
        }

        _countDown -= Time.deltaTime;
    }

    private IEnumerator Spawn()
    {
        Instantiate(_cube, _spawnPoint.position, _spawnPoint.rotation);
        yield return new WaitForSeconds(_timeSpawn);
    }
}
