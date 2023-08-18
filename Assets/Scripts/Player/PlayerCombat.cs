using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Weapon _currentWeapon;

    public void TryShoot()
    {
        _currentWeapon.TryShoot();
    }
}