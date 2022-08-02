using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    EnemyGroupSetting[] groupSettings;
    Vector3 birthPoint;
    EnemyPool pool;
    int currentGroup;

    //依赖倒置
    public void Init(EnemyGroupSetting[] groupSettings,EnemyPool pool ,Vector3 EnemyBirthPoint)
    {
        this.groupSettings = groupSettings;
        this.birthPoint = EnemyBirthPoint;
        this.pool = pool;
    }

    private void CreatEnemy(int num)
    {
        for(int i = 0; i < num; i++)
        {
            pool.GetInstance(birthPoint, 0);
        }
    }

    public void TurnToNextgroup()//需要订阅敌人全灭事件，每次全灭激活下一波敌军
    {
        currentGroup++;
        InitGroup();
    }

    private void InitGroup()
    {
        StartCoroutine(EnemyGroupInit());
    }

    //每一波敌军初始化
    IEnumerator EnemyGroupInit()
    {
        EnemyGroupSetting groupSetting = groupSettings[currentGroup];
        yield return new WaitForSeconds(groupSetting.PreTime);
        CreatEnemy(groupSetting.EnemyNum);

    }

}
