using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour {

    ConstantForce2D cForce;
    [SerializeField]
    float speed;
    [SerializeField]
    float waveDownSpeed;
    [SerializeField]
    float airSpeedMultiplier;
    [SerializeField]
    float jumpForce;
    GameController gameController;
    [SerializeField]
    public bool grounded;
    Rigidbody2D rigid;
    public bool onWaveDown;

    // Use this for initialization
    void Start () {

        rigid = GetComponent<Rigidbody2D>();
        gameController = FindObjectOfType<GameController>();
        cForce = GetComponent<ConstantForce2D>();

    }
	
	// Update is called once per frame
	void Update () {

        float boolfloat = grounded ? 1 : airSpeedMultiplier;
        float boolInt2 = onWaveDown ? waveDownSpeed : 0;

        cForce.force = new Vector2(gameController.GetWindForce() * boolfloat + boolInt2 * -Input.GetAxis("Vertical"), Input.GetAxis("Vertical") * speed * boolfloat);


	}

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && grounded)
        {
            rigid.AddForce(new Vector2(0, jumpForce));

        }
    }


}
