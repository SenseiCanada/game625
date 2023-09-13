using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    protected bool collidedWithPlayer;
    protected GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }


    protected void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            CollisionWithCollectable(other.gameObject);
            Object.Destroy(gameObject);
        }
    }

    protected virtual void CollisionWithCollectable(GameObject player)
    {
        return;
    }

}
