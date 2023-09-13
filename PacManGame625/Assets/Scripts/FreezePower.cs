using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePower : Collectable
{
       protected override void CollisionWithCollectable(GameObject player)
    {
        StartFreezeTimer();
                
    }
    protected void StartFreezeTimer()
    {
        gameManager.StartFreeze = true;
    }
}
