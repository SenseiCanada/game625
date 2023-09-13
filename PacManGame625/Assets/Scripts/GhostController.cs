using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostController : GhostClass
{
    
    protected NavMeshAgent NormalGhostAgent;

    // Start is called before the first frame update
    void Start()
    {
        GhostActive = true;

        player = GameObject.FindGameObjectWithTag("Player");
        NormalGhostAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        HuntPlayer();
    }
    private void HuntPlayer()
    {
            if (NormalGhostAgent != null && GhostActive)
            {
                NormalGhostAgent.isStopped = false;
                NormalGhostAgent.SetDestination(player.transform.position);
            }
            else
            {
                NormalGhostAgent.isStopped = true;
            }

    }

    protected override void CollisionWithPlayer(GameObject player)
    {
        if (GhostActive)
        {
            KillPlayer();
        }
        else if (!GhostActive)
        {
            KillGhost();
        }
    }


    protected void KillPlayer()
    {
           
        gameManager.Lives--;
       
    }
    protected void KillGhost()
    {
        gameManager.Score = gameManager.Score + 3;
        //RemoveGhost(gameObject);


    }
    public void RemoveGhost(GameObject ghostToRemove)
    {
        // Check if the ghostToRemove exists in the array
        if (ghostToRemove != null)
        {
            // Create a new array without the ghostToRemove
            GameObject[] newGhostObjects = new GameObject[ghostObjects.Length - 1];

            int newIndex = 0;

            // Copy all objects from the old array to the new array, excluding the ghostToRemove
            for (int i = 0; i < ghostObjects.Length; i++)
            {
                if (ghostObjects[i] != ghostToRemove)
                {
                    newGhostObjects[newIndex] = ghostObjects[i];
                    newIndex++;
                }
            }

            // Update the ghostObjects array with the new array
            ghostObjects = newGhostObjects;

            // Destroy the ghostToRemove object
            Destroy(ghostToRemove);
        }
    }

}
