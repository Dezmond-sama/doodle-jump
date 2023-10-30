using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Camera))]
public class PlayerDeath : MonoBehaviour
{
    private Camera _camera;
    public UnityEvent TargetOutOfView = new UnityEvent();
    [SerializeField] private Transform _target;
    private void Start()
    {
        _camera = GetComponent<Camera>();
    }

    private void Update()
    {
        Vector3 pos = _camera.WorldToViewportPoint(_target.position);
        if (pos.y < 0)
        {
            TargetOutOfView.Invoke();
        }
    }
}
