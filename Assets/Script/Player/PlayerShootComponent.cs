using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootComponent : MonoBehaviour
{

    //依赖武器类，根据武器决定伤害、命中范围、命中距离等
    //Test
    public void Shoot(Vector3 gun, Vector3 target)
    {

        RaycastHit hit;
        Physics.Raycast(gun, target - gun,out hit,7);
        //碰撞判定
        if (hit.collider.CompareTag("Attackable"))
        {
            Debug.Log("命中"+hit.collider.name);
            //伤害判定
            Hurt(hit.collider.gameObject.GetComponent<EnemyEntity>());

        }


    }

    private void Hurt(EnemyEntity enemy)
    {
        //Test
        if (enemy.hp > 0)
        {
            enemy.hp--;

        }
        else
        {
            Debug.Log("死亡");
        }
    }







}
