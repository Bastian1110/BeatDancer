using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : State
{
    private SkeletonMachine sm;

    public Dead(SkeletonMachine stateMachine) : base("Dead", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.DestroySkeleton();
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }

}
