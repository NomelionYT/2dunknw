using System;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    private float _damage;

    public void Init(float speed)
    {
        _rigidbody.velocity = transform.up * speed;
        _damage = speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<EnemyHP>())
        {
            col.GetComponent<EnemyHP>().GetDamage(_damage);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}