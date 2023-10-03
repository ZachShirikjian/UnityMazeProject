using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //VARIABLES//
    public bool levelComplete = false;
    public int score = 0;
    public int totalScore; 

    public int timer = 30;
    //REFERENCES//
    public TextMeshProUGUI LevelCompleteText;
    public TextMeshProUGUI AllCoinsCollected;
    public TextMeshProUGUI scoreText; //reference to the coinNumber text; updates every time you get a coin in the level
    public TextMeshProUGUI timerText; //reference to the timer showing how much time you have left in seconds before time runs out!
    // Start is called before the first frame update
    void Start()
    {
        AllCoinsCollected.text = "";
        LevelCompleteText.text = "";
        timerText.text = "30";
        levelComplete = false;
        scoreText.text = "0";
        score = 0;
        timer = 30;
        StartCoroutine(CountdownTimer());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        timerText.text = timer.ToString();

        //If the player gets all the coins in a level
        //Let the game know all coins were collected!
        if(score >= totalScore)
        {
            AllCoinsCollected.text = "ALL COINS COLLECTED";
        }
    }

    public void LevelComplete()
    {
        Debug.Log("LEVEL COMPLETE!!!");
        LevelCompleteText.text = "LEVEL COMPLETE!";
        levelComplete = true;
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
        LevelCompleteText.text = "GAME OVER";
        levelComplete = true;
    }

    IEnumerator CountdownTimer()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = timer; i > 0; i--)
        {
            yield return new WaitForSeconds(1f);
            timer--;
        }
        Debug.Log("TIME'S UP!");

    }
}
