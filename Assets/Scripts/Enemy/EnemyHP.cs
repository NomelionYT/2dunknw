using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHP : MonoBehaviour
{
    private float _hp;
    public UnityAction<float> HealthChanged;

    private void Start()
    {
        _hp = 50f;
        HealthChanged?.Invoke(_hp);
    }
    
    private void Update()
    {
        if (_hp <= 0)
            Destroy(gameObject);
    }

    public void GetDamage(float damage)
    {
        _hp -= damage;
        HealthChanged?.Invoke(_hp);
    }
}