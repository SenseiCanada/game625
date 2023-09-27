using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : GroceryClass

{
    private void Start()
    {
        weight = 1f;
        calories = 10f;
        price = 100f;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Notify(this, NotificationType.FruitCollected);
            GameObject.Destroy(gameObject);
        }
        
    }
}
