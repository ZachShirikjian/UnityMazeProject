using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //VARIABLES//
    public bool levelComplete = false;
    //REFERENCES//
    public TextMeshProUGUI LevelCompleteText;
    // Start is called before the first frame update
    void Start()
    {
        LevelCompleteText.text = "";
        levelComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelComplete()
    {
        Debug.Log("LEVEL COMPLETE!!!");
        LevelCompleteText.text = "LEVEL COMPLETE!";
        levelComplete = true;
    }
}
