using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextWaveTrigger : MonoBehaviour {

    GameController gameController;
    [SerializeField]
    float xOffset;

	// Use this for initialization
	void Start () {

        gameController = FindObjectOfType<GameController>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            gameController.InstanciateWave(transform.parent.position + new Vector3(xOffset, 0, 0));

    }
}
