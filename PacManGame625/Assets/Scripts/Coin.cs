using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : Collectable
{

    protected override void CollisionWithCollectable(GameObject player)
    {
        IncreaseScore();
        
    }

    protected void IncreaseScore()
    {
        gameManager.Score++;
        
    }
}
