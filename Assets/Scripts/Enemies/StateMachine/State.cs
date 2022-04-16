using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By Sebastian Mora
//This is an abstract class for creating states fo a FSM
public class State
{
    public string stateName;
    protected StateMachine stateMachine;

    public State(string stateName, StateMachine stateMachine)
    {
        this.stateName = stateName;
        this.stateMachine = stateMachine;
    }

    public virtual void Enter() { }
    public virtual void UpdateLogic() { }
    public virtual void UpdatePhysics() { }
    public virtual void Exit() { }
}
