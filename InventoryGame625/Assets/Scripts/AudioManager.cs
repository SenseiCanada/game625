using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour, Observer
{
    
    public AudioSource audioSource;
    // Start is called before the first frame update

    public void OnNotify(object obj, NotificationType notificationType)
    {
        if (notificationType == NotificationType.FruitCollected)
        {
            PlayPickUpSound();
        }

        if (notificationType == NotificationType.MeatCollected)
        {
            PlayPickUpSound();
        }

        if (notificationType == NotificationType.VegetableCollected)
        {
            PlayPickUpSound();
        }
    }
void Start()
    {
        audioSource = GetComponent<AudioSource>();

        foreach (Observable subject in FindObjectsOfType<Observable>())
        {
            subject.AddObserver(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPickUpSound()
    {
        audioSource.Play();
    }
}
