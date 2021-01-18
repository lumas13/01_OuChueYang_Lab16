using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject scoreCounter;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Call the GameManager
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score += 1;
        scoreCounter.GetComponent<Text>().text = "Score: " + score;
    }
}
