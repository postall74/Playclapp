using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;

    public float Speed => _speed;

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public void Finish()
    {
        Destroy(gameObject);
    }
}
