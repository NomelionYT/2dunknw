using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform _player;
    private float _speed = 2f;
    private bool _canMove = true;

    private void Start()
    {
        _player = FindObjectOfType<PlayerMovement>().transform; 
    }

    private void Update()
    {
        if (_canMove)
            Move();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerHP>())
            _canMove = false;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHP>())
            _canMove = true;
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
    }
}