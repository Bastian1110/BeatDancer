using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    private SkeletonMachine sm;

    private float waitTime = 3f;
    private float waitCounter;

    public Idle(SkeletonMachine stateMachine) : base("Idle", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        waitCounter = 0f;
        sm.animator.SetBool("isWalking",false);
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        waitCounter += Time.deltaTime;
        if(waitCounter > waitTime)
        {
            stateMachine.ChangeState(sm.walkState);
        }
    }

    public override void Exit()
    {
        base.Exit();
        if (sm.moveRight)
        {
            sm.transform.eulerAngles = new Vector3(0, -180, 0);
            sm.moveRight = false;
        }
        else
        {
            sm.transform.eulerAngles = new Vector3(0, 0, 0);
            sm.moveRight = true;
        }
    }
}
