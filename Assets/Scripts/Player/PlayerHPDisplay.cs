using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPDisplay : MonoBehaviour
{
    [SerializeField] private Text _HPText;
    [SerializeField] private Image _healthBarFilling;
    [SerializeField] private PlayerHP _playerHP;
    
    private float _maxHP;
    private float _hp;

    private bool _maxHPFilled = false;

    private void OnEnable()
    {
        _playerHP.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _playerHP.HealthChanged -= OnHealthChanged;
    }

    private void Update()
    {
        print(_hp + "   " + _maxHP);
        _healthBarFilling.fillAmount = _hp / _maxHP;
        _HPText.text = _hp.ToString();
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