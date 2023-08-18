using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPDisplay : MonoBehaviour
{
    [SerializeField] private Image _healthBarFilling;
    [SerializeField] private EnemyHP _enemyHP;
    
    private float _maxHP;
    private float _hp;
    
    private bool _maxHPFilled = false;

    private void OnEnable()
    {
        _enemyHP.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _enemyHP.HealthChanged -= OnHealthChanged;
    }

    private void Update()
    {
        _healthBarFilling.fillAmount = _hp / _maxHP;
    }

    private void OnHealthChanged(float hp)
    {
        _hp = hp;
        if (!_maxHPFilled)
        {
            _maxHP = _hp;
            _maxHPFilled = true;
        }
    }
}