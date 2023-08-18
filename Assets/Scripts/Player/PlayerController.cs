using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerMovement _movement;
    [SerializeField] private PlayerCombat _combat;

    private void OnEnable()
    {
        PlayerInput.MoveKeyPressing += OnMoveKeyPressing;
        PlayerInput.ShootKeyPressing += OnShootKeyPressing;

    }

    private void OnDisable()
    {
        PlayerInput.MoveKeyPressing -= OnMoveKeyPressing;
        PlayerInput.ShootKeyPressing -= OnShootKeyPressing;
    }

    private void OnShootKeyPressing()
    {
        _combat.TryShoot();
    }

    private void OnMoveKeyPressing(Vector2 direction)
    {
        _movement.Move(direction);
    }
}