using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs_Movement : MonoBehaviour {

	private Rigidbody2D rb;
	private int JumpCount;
	public int MaxJumps;
	public float JumpHeight;
	public float MovementSpeed;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		float HorMov = Input.GetAxis ("Horizontal");

		rb.AddForce(new Vector2(HorMov * MovementSpeed, 0));

		if (Input.GetButtonDown ("Jump") && JumpCount != MaxJumps) {

			JumpCount = JumpCount + 1;
			rb.velocity = Vector2.up * JumpHeight;

		}

	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Ground") {
			Debug.Log ("Landed");
			JumpCount = 0;
		}

	}
}