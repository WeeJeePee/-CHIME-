using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cs_PlayerManagement : MonoBehaviour {

	public int MaxHealth;
	static private int CurrentHealth;
	static public int Currency;

	void Awake(){
		
		CurrentHealth = MaxHealth;

	}


	public void TakeDamage(int DamageValue){

		if (CurrentHealth - DamageValue <= 0){
			PlayerDeath();
		} else if (CurrentHealth > 0) {
			CurrentHealth = CurrentHealth - DamageValue;
			Debug.Log (CurrentHealth);
		}

	}

	public void PlayerDeath (){
		Destroy (gameObject);
	}
}
