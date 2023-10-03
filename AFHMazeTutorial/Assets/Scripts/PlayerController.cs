using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES//
    private float speed = 50f; 
    private Vector2 move; //Direction we're moving in the X axis and Y axis, set as a coordinate
    //REFERENCES//
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb2d.MovePosition(rb2d.position + (move * speed * Time.deltaTime));

    }
}
