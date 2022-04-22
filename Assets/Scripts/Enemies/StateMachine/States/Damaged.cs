using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : State
{
    private SkeletonMachine sm;

    public Damaged(SkeletonMachine stateMachine) : base("Damaged", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.StartDamagedAnimation();
    }

    public override void UpdateLogic()
    {
        if (sm.health > 0)
        {
            sm.ChangeState(sm.walkState);
        }
        else
        {
            sm.animator.SetBool("isDead", true);
            sm.ChangeState(sm.deadState);
        }
    }
}
