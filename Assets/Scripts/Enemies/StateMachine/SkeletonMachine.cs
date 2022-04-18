using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMachine : StateMachine
{
    public Idle idleState;
    public Walk walkState;
    public Attack attackState;

    public Transform groundDetector;
    public Transform wallDetector;
    public bool moveRight = true;

    public Transform player;

    public Animator animator;

    public float viewRange = 5;

    public GameObject projectile;

    private void Awake()
    {
        idleState = new Idle(this);
        walkState = new Walk(this);
        attackState = new Attack(this);
        animator = GetComponent<Animator>();
    }

    protected override State GetInitialState()
    {
        return idleState;
    }
}
