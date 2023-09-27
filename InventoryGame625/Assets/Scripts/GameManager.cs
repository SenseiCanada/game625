using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour, Observer
{
    public TMP_Text weightText;
    public TMP_Text caloriesText;
    public TMP_Text budgetText;
    public TMP_Text fruitText;
    public TMP_Text meatText;
    public TMP_Text vegetableText;

    public int fruitAmount;
    public int meatAmount;
    public int vegetableAmount;

    public float weight;
    public float calories;
    public float budget;

   
    // Start is called before the first frame update
    void Start()
    {
        fruitAmount = 0;
        weight = 0f;
        calories = 0f;
        budget = 10000f;

        
        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }

    }

    // Update is called once per frame
    void Update()
    {
        weightText.text = "Weight: " + weight.ToString();
        caloriesText.text = "Calories: " + calories.ToString();
        budgetText.text = "Budget: " + budget.ToString();
        fruitText.text = "Fruit: " + fruitAmount.ToString();
        meatText.text = "Meat: " + meatAmount.ToString();
        vegetableText.text = "Vegetables: " + vegetableAmount.ToString();


    }

    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.FruitCollected)
        {
            fruitAmount++;
            weight += 1f;
            calories += 10f;
            budget -= 100f;
        }

        if (notificationType == NotificationType.MeatCollected)
        {
            meatAmount++;
            weight += 10f;
            calories += 100f;
            budget -= 10f;
        }

        if (notificationType == NotificationType.VegetableCollected)
        {
            vegetableAmount++;
            weight += 100f;
            calories += 10f;
            budget -= 1f;
        }
    }


}