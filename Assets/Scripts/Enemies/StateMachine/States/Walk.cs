using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : State
{
    private SkeletonMachine sm;

    private float walkSpeed = 1f;
    private float groundRayDistance = 1f;
    private float wallRayDistance = 0.3f;

    public Walk(SkeletonMachine stateMachine) : base("Walk", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }
    public override void Enter()
    {
        base.Enter();
        sm.animator.SetBool("isWalking", true);
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        RaycastHit2D groundInfo = Physics2D.Raycast(sm.groundDetector.position, Vector2.down, groundRayDistance);
        RaycastHit2D wallInfo = Physics2D.Raycast(sm.wallDetector.position, sm.transform.right, wallRayDistance);
        if(!groundInfo.collider || wallInfo.collider)
        {
            sm.wait = true;
            stateMachine.ChangeState(sm.idleState);
        }

        float playerDistance = Vector2.Distance(sm.target.position,sm.transform.position);
        if(playerDistance < sm.viewRange)
        {
            sm.wait = false;
            stateMachine.ChangeState(sm.attackState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        sm.transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
