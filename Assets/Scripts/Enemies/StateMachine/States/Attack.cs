using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    private SkeletonMachine sm;

    private float shootingTime;
    public float fireRate = 2000f; 
    public float shootingPower = 20f; 

    public Attack(SkeletonMachine stateMachine) : base("Attack", stateMachine)
    {
        sm = (SkeletonMachine)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        sm.animator.SetBool("playerDetect", true);
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        float playerDistance = Vector2.Distance(sm.player.position, sm.transform.position);
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
        if(Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;
            GameObject newProjectile = Object.Instantiate(sm.projectile);
            newProjectile.transform.position = sm.transform.position;
            newProjectile.GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
            newProjectile.SetActive(true);
        }
        
    }
}
