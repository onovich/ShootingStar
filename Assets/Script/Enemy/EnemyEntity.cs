using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    normal,
}
public class EnemyEntity : MonoBehaviour
{
    public EnemyType EnemyType;
    public EnemySetting setting;
    public int hp;

    public void Init()
    {
        hp = setting.maxHp;
    }

    public void Rush()
    {

    }
    public void AttackDoor()
    {

    }
    public void ShootDoor()
    {

    }
    public bool SeeDoor()
    {
        return false;
    }
    public bool ReachDoor()
    {
        return false;
    }
    public bool BreakDoor()
    {
        return false;
    }
    public void Die()
    {

    }
}
