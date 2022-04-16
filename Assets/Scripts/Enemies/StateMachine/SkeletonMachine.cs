using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonMachine : StateMachine
{
    public Idle idleState;
    public Walk walkState;

    public Transform groundDetector;
    public Transform wallDetector;
    public bool moveRight = true;

    public Animator animator;

    private void Awake()
    {
        idleState = new Idle(this);
        walkState = new Walk(this);
        animator = GetComponent<Animator>();
    }

    protected override State GetInitialState()
    {
        return idleState;
    }
}
