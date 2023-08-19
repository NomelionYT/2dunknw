using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHP : MonoBehaviour
{
    private float _hp;
    public UnityAction<float> HealthChanged;

    private void Start()
    {
        _hp = 100f;
        HealthChanged?.Invoke(_hp);
    }

    private void Update()
    {
        if (_hp <= 0)
            gameObject.SetActive(false);
    }

    public void GetDamage(float damage)
    {
        _hp -= damage;
        HealthChanged?.Invoke(_hp);
    }
}