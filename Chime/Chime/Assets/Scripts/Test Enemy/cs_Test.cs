using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs_Test : MonoBehaviour {

	public int DamageToDeal;

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "Player") {
			coll.gameObject.SendMessage ("TakeDamage", DamageToDeal);
		}

	}
}
