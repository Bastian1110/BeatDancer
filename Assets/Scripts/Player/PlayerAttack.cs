using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
    public GameObject projectile;
    Animator anim;

    private float fireRate = 0.5f;
    private float nextFire = 0.0f;

    public bool rightFire = true;

    void Start()
    {
        instance = this;
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            AttackAnimation();
            Fire();
        }
        float direction = Input.GetAxisRaw("Horizontal");
        if (direction == 1)
        {
            rightFire = true;
        }
        else if(direction == -1)
        {
            rightFire = false;
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

    void AttackAnimation()
    {
        StartCoroutine(handleAttackAnimation());
    }

    IEnumerator handleAttackAnimation()
    {
        anim.SetBool("isAttack", true);
        yield return new WaitForSeconds(0.6f);
        anim.SetBool("isAttack", false);
    }
}
