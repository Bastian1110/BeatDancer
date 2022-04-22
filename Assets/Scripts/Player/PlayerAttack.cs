using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectile;

    private float fireRate = 0.2f;
    private float nextFire = 0.0f;

    public float projectileSpeed = 5;

    private Transform trans;

    void Start()
    {
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Fire();
            }
        }
    }

    void Fire()
    {
        GameObject newProjectile = Instantiate(projectile);
        newProjectile.transform.position = gameObject.transform.position;
        newProjectile.SetActive(true);

    }
}
