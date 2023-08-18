using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    private float _damage = 10f;
    private Coroutine _attackCoroutine;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerHP>())
            _attackCoroutine = StartCoroutine(AttackCoroutine(col.GetComponent<PlayerHP>()));
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerHP>())
            StopCoroutine(_attackCoroutine);
    }

    private void Attack(PlayerHP playerHP)
    {
        playerHP.GetDamage(_damage);
    }

    IEnumerator AttackCoroutine(PlayerHP playerHp)
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Attack(playerHp);
        }
    }
}
