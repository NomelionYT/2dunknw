using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public static event UnityAction<Vector2> MoveKeyPressing;
    public static event UnityAction ShootKeyPressing;

    private void Update()
    {
        CheckShootKeyPressing();
    }

    private void FixedUpdate()
    {
        CheckMoveKeysPressing();
    }

    private void CheckMoveKeysPressing()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            direction += Vector2.up;

        if (Input.GetKey(KeyCode.A))
            direction += Vector2.left;

        if (Input.GetKey(KeyCode.S))
            direction += Vector2.down;

        if (Input.GetKey(KeyCode.D))
            direction += Vector2.right;

        MoveKeyPressing?.Invoke(direction);
    }

    private void CheckShootKeyPressing()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            ShootKeyPressing?.Invoke();
    }
}
