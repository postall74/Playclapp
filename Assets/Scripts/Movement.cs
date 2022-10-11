using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Transform _target;
    private Cube _cube;

    public void SetTargetPosition(Transform target)
    {
        _target = target;
    }

    private void Start()
    {
        _cube = GetComponent<Cube>();
        _target = FindObjectOfType<Finish>().GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 direction = _target.position - transform.position;
        transform.Translate(_cube.Speed * Time.deltaTime * direction.normalized, Space.World);
    }
}
