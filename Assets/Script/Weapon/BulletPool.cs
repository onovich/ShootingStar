using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : GameObjectPool
{
    public override void InitPool(string objPoolName, Transform objTransform)
    {

        base.InitPool(objPoolName, objTransform);
        preFab = Resources.Load("bulletSample") as GameObject;
        if (preFab == null)
        {
            Debug.Log("PreFabGetError");
        }

    }


    public override GameObject GetInstance(Vector2 position, float lifetime)
    {
        lifetime = 5;
        return base.GetInstance(position, lifetime);

    }

    public override void Destroy()
    {
        base.Destroy();
        Destroy(preFab);
    }
}
