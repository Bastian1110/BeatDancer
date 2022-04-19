using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    private SkeletonMachine sm;

    private float waitTime;
    private float waitCounter;

    public Idle(SkeletonMachine stateMachine) : base("Idle", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        waitCounter = 0f;
        if (!sm.wait)
        {
            waitTime = 0f;
        }
        else
        {
            waitTime = 3f;
        }
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

        float playerDistance = Vector2.Distance(sm.target.position, sm.transform.position);
        if (playerDistance < sm.viewRange)
        {
            stateMachine.ChangeState(sm.attackState);
        }
    }

    public override void Exit()
    {
        base.Exit();
        if (sm.wait)
        {
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
}
