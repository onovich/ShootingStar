using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDoorState : FSMState
{
    public EnemyAttackDoorState(FSMSystem fsm) : base(fsm)
    {
        stateID = StateID.AttackDoor;
    }

    public override void Act(GameObject enemy)
    {
        enemy.GetComponent<EnemyEntity>().AttackDoor();
    }

    public override void Reason(GameObject enemy)
    {
        if (enemy.GetComponent<EnemyEntity>().BreakDoor())
        {
            fsm.PerformTransition(Transition.DestroyDoor);

        }
    }
}
