using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth = 20;
	public int currentHealth;

	//Animator anim;
	CapsuleCollider capsuleCollider;
	bool isDead;

	void Awake () {
		//anim = GetComponent <Animator> ();
		capsuleCollider = GetComponent <CapsuleCollider> ();
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TakeDamage (int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			Death();
		}
	}

	void Death () {
		isDead = true;
		//capsuleCollider.isTrigger = true;
		//anim.SetTrigger("Dead");
		Destroy (gameObject);
	}
}
