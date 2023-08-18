using System;
using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private float _reloadTime;
    [SerializeField] private float _shotPower = 5f;

    private bool _canShoot = true;

    private IEnumerator Reloading()
    {
        yield return new WaitForSeconds(_reloadTime);

        _canShoot = true;
    }

    public void TryShoot()
    {
        if (!_canShoot)
            return;

        _canShoot = false;

        var bullet = Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.Euler(transform.eulerAngles));
        bullet.Init(_shotPower);

        StartCoroutine(Reloading());
    }
}