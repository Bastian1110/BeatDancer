using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;

    private float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Start()
    {
        return;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Fire();
        }
    }

    void Fire()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Object.Instantiate(projectile, transform.position, Quaternion.identity);
        }

    }
}
