using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBasic : MonoBehaviour
{
    //Reference to PlayerController script on the Player GameObject
    private PlayerControllerBasic player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerControllerBasic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player can interact");
            player.canInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        player.canInteract = false;
    }
}
