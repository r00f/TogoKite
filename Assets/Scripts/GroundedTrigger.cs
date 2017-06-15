using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedTrigger : MonoBehaviour {

    PlayerLogic player;

	// Use this for initialization
	void Start () {

        player = GetComponentInParent<PlayerLogic>();


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Floor"))
        player.grounded = true;

    }
    void OnTriggerExit2D(Collider2D other)
    {
        player.grounded = false;
    }
}
