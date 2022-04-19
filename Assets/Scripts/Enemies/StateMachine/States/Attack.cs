using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    private SkeletonMachine sm;

    private float fireRate = 1f;
    private float nextFire = 0.0f;

    public Attack(SkeletonMachine stateMachine) : base("Attack", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.animator.SetBool("playerDetect", true);
        float direction = sm.target.position.x - sm.transform.position.x;
        if(direction < 0)
        {
            sm.transform.eulerAngles = new Vector3(0, -180, 0);
        }
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        float playerDistance = Vector2.Distance(sm.target.position, sm.transform.position);
        if (playerDistance > sm.viewRange)
        {
            stateMachine.ChangeState(sm.walkState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Fire();
    }

    public override void Exit()
    {
        base.Exit();
        sm.animator.SetBool("playerDetect", false);
    }

    private void Fire()
    {
        if(Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Object.Instantiate(sm.projectile, sm.transform.position, Quaternion.identity);
        }
    }
}
