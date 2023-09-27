using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Vegetable :GroceryClass
{
    private void Start()
    {
        weight = 100f;
        calories = 10f;
        price = 1f;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Notify(this, NotificationType.VegetableCollected);
            GameObject.Destroy(gameObject);
        }

    }
}
