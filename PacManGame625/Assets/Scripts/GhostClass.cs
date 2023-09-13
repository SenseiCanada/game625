using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostClass : MonoBehaviour
{
    public GameObject player;
    public bool GhostActive;
    public GameManager gameManager;
    public GameObject[] ghostObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CollisionWithPlayer(other.gameObject);
            
            Object.Destroy(gameObject);
        }

    }

    protected virtual void CollisionWithPlayer(GameObject player)
    {
        return;
    }

    
}
