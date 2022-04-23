using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Skeleton Finite State Machine AI
//By Sebastian Mora
public class SkeletonMachine : StateMachine
{
    public Idle idleState;
    public Walk walkState;
    public Attack attackState;
    public Damaged damagedState;
    public Dead deadState;

    public Transform groundDetector;
    public Transform wallDetector;
    public bool moveRight = true;
    public bool wait;

    public Transform target;

    public Animator animator;

    public float viewRange = 5;

    public GameObject projectile;

    public float health = 1f;

    private void Awake()
    {
        idleState = new Idle(this);
        walkState = new Walk(this);
        attackState = new Attack(this);
        damagedState = new Damaged(this);
        deadState = new Dead(this);

        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected override State GetInitialState()
    {
        return idleState;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            health -= 0.16f;
            ChangeState(damagedState);
        }
    }

    public void StartDamagedAnimation()
    {
        StartCoroutine(DamagedAnimationHandler());
    }

    IEnumerator DamagedAnimationHandler()
    {
        animator.SetBool("isHurt", true);
        yield return new WaitForSeconds(0.4f);
        animator.SetBool("isHurt", false);
    }

    public void DestroySkeleton()
    {
        StartCoroutine(DestroySkeletonHelper());
    }

    IEnumerator DestroySkeletonHelper()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }


}
