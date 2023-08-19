using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        Follow(_target);
    }

    private void Follow(Transform targetTransform)
    {
        gameObject.transform.position = new Vector3(targetTransform.position.x, targetTransform.position.y, targetTransform.position.z - 1);
    }
}