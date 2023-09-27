using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observable : MonoBehaviour
{
    private List<Observer> _observers = new List<Observer>();

    // adding observer to the list
    public void AddObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    // remove observer from the list
    public void RemoveObserver(Observer observer)
    {
        _observers.Remove(observer);
    }

    // notify all observers
    public void Notify(object obj, NotificationType notificationType)
    {
        // iterate over the list of observers (if any) and notify each and every of them
        // note that there can be an object passed and, additionally, a notification type
        foreach (Observer observer in _observers)
        {
            observer.OnNotify(obj, notificationType);
        }
    }
}
