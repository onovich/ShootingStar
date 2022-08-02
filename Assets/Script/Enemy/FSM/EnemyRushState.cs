using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRushState : FSMState
{
    public EnemyRushState(FSMSystem fsm) : base(fsm)
    {
        stateID = StateID.Rush;
    }

    public override void Act(GameObject enemy)
    {
        enemy.GetComponent<EnemyEntity>().Rush();
    }

    public override void Reason(GameObject enemy)
    {
        if (enemy.GetComponent<EnemyEntity>().SeeDoor())
        {
            fsm.PerformTransition(Transition.SeeDoor);

        }
    }
}
