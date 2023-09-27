using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class GroceryClass : Observable
{
    public GameObject player;


    public float weight;
    public float calories;
    public float price;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    public void Update()
    {
        
    }


    

   
}
