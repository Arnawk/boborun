using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour {
    private Rigidbody2D myRigidBody;
    public float bunnyJumpForce = 50f;
    private Animator myAnim;
	// Use this for initialization
	void Start () {

        myRigidBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetButtonDown("Jump")) || (Input.GetMouseButtonDown(0)))
        {
            myRigidBody.AddForce(transform.up* bunnyJumpForce);
        }
        myAnim.SetFloat("vVelocity",myRigidBody.velocity.y);
    }
}
