using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Transition
{
    NullTransition = 0,


    SeeDoor,//大门进入视野
    ReachDoor,//抵达大门
    DestroyDoor,//摧毁大门

}


public enum StateID
{
    NullStateID = 0,

    Rush,//奔跑
    ShootDoor,//远程攻击门
    AttackDoor,//近战攻击门
    //BreakIn,//冲进大门
}
public abstract class FSMState
{
    protected StateID stateID;
    protected FSMSystem fsm;

    public StateID ID
    {
        get { return stateID; }

    }

    protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();

    public FSMState(FSMSystem fsm)
    {
        this.fsm = fsm;
    }


    public void ADDTransition(Transition transition, StateID id)
    {
        if (transition == Transition.NullTransition)
        {
            Debug.LogError("不允许添加NullTransition");
            return;
        }
        if (id == StateID.NullStateID)
        {
            Debug.LogError("不允许添加NullStateID");
            return;
        }
        if (map.ContainsKey(transition))
        {
            Debug.LogError("已经存在transition");
            return;
        }
        map.Add(transition, id);
    }
    public void DeleteTransition(Transition transition)
    {
        if (transition == Transition.NullTransition)
        {
            Debug.LogError("不允许删除NullTransition");
            return;
        }
        if (!map.ContainsKey(transition))
        {
            Debug.LogError("transition不存在");
            return;
        }
        map.Remove(transition);

    }
    public StateID GetStateID(Transition transition)
    {
        if (map.ContainsKey(transition))
        {
            return map[transition];
        }
        return StateID.NullStateID;
    }





    public virtual void DoBeforeEntering() { }

    public virtual void DoAfterLeaving() { }

    public abstract void Act(GameObject npc);

    public abstract void Reason(GameObject npc);





}
