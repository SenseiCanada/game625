using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score;
    public float FreezeTimer;
    public bool StartFreeze;
    public GameObject ghost;
    public GameObject[] ghostObjects;
    public GameObject coins;
    public int Lives;
    public TMP_Text scoreText;
    public TMP_Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        ghost = GameObject.FindWithTag("Ghost");
        GameObject[] ghostObjects = GameObject.FindGameObjectsWithTag("Ghost");
        
        coins = GameObject.FindWithTag("Coins");
        Score = 0;
        StartFreeze = false;
        FreezeTimer = 0f;
        Lives = 3;

        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        StartTimer();
        scoreText.text = "Score: " + Score.ToString();
        livesText.text = "Lives: " + Lives.ToString();

        GameOver();
        YouWin();

    }

    public void StartTimer()
    {
        if(StartFreeze == true)
        {
            FreezeTimer += Time.deltaTime;
            foreach (GameObject ghost in ghostObjects)
            {
                ghost.GetComponent<GhostController>().GhostActive = false;
            }
            if(FreezeTimer >=3f)
                {
                ResetTimer();
                }
        }
    }

    public void ResetTimer()
    {
        StartFreeze = false;
        FreezeTimer = 0f;
        
        foreach (GameObject ghost in ghostObjects)
        {
           ghost.GetComponent<GhostController>().GhostActive = true;
        }
        
        
    }

    public void GameOver()
    {
        if(Lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void YouWin()
    {
        if (coins.transform.childCount == 0)
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}
