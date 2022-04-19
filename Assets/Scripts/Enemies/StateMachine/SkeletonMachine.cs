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

    public Transform groundDetector;
    public Transform wallDetector;
    public bool moveRight = true;
    public bool wait;

    public Transform target;

    public Animator animator;

    public float viewRange = 5;

    public GameObject projectile;

    private void Awake()
    {
        idleState = new Idle(this);
        walkState = new Walk(this);
        attackState = new Attack(this);

        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected override State GetInitialState()
    {
        return idleState;
    }
}
