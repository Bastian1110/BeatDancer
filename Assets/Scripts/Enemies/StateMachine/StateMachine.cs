using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is a little implementation of an abstract FSM
//By Sebastian Mora

public class StateMachine : MonoBehaviour
{
    State currentState;

    void Start()
    {
        currentState = GetInitialState();
        if(currentState != null)
        {
            currentState.Enter();
        }
    }

    void Update()
    {
        if(currentState != null)
        {
            currentState.UpdateLogic();
        }
    }

    void LateUpdate()
    {
        if (currentState != null)
        {
            currentState.UpdatePhysics();
        }   
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }

    protected virtual State GetInitialState()
    {
        return null;
    }
}
