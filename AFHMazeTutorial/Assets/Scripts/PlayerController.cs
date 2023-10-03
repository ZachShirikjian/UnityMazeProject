using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//
    private float speed = 25f; 
    private Vector2 move; //Direction we're moving in the X axis and Y axis, set as a coordinate
    public bool canInteract = false;

    //REFERENCES//
    private Rigidbody2D rb2d; //Reference to the Player's Rigidbody2D (Physics and Movement)
    private GameManager gm; //Reference to the GameManager
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Every frame, move the player based on their Horizontal and Vertical Inputs
        //If the level hasn't been completed yet, the player can move. 
        //Otherwise, the player can't move when the level is complete.
        if(gm.levelComplete == false)
        {
            move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            rb2d.MovePosition(rb2d.position + (move * speed * Time.deltaTime));
        }


        //If the Player presses Space while at the Door
        //Call the GameManager's LevelComplete() method to end the level.
        if(Input.GetKeyDown(KeyCode.Space) && canInteract == true)
        {
            Debug.Log("Completed the Maze!");
            gm.LevelComplete();
        }
    }
}
