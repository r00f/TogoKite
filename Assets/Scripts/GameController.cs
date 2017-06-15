using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField]
    float windForce;
    [SerializeField]
    List<GameObject> wavePrefabs = new List<GameObject>();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float GetWindForce()
    {
        return windForce;
    }

    public void InstanciateWave(Vector3 position)
    {
        Instantiate(wavePrefabs[Random.Range(0, wavePrefabs.Count)], position, Quaternion.identity);
    }
}
