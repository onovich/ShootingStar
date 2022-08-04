using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootDoorState : FSMState
{
    public EnemyShootDoorState(FSMSystem fsm) : base(fsm)
    {
        stateID = StateID.ShootDoor;
    }

    public override void Act(GameObject enemy)
    {
        enemy.GetComponent<EnemyEntity>().ShootDoor();
    }

    public override void Reason(GameObject enemy)
    {
        if (enemy.GetComponent<EnemyEntity>().ReachDoor())
        {
            fsm.PerformTransition(Transition.ReachDoor);

        }
    }
}
