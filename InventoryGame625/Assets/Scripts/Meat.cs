using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Meat : GroceryClass
{ 
    private void Start()
    {
        weight = 10f;
        calories = 100f;
        price = 10f;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Notify(this, NotificationType.MeatCollected);
            GameObject.Destroy(gameObject);
        }

    }
}

