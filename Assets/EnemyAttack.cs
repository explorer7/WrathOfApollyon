using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 2.5f;
	public int attackDamage = 4;

	Animator anim;
	GameObject Player;
	PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	bool playerInRange;
	float timer;

	void Awake () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = Player.GetComponent<PlayerHealth> ();
		//enemyHealth = GetComponent<EnemyHealth> ();
		anim = GetComponent <Animator> ();
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject == Player) {
			playerInRange = true;
			(GetComponent ("Practicemove") as MonoBehaviour).enabled = false;
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject == Player) {
			playerInRange = false;
			(GetComponent ("Practicemove") as MonoBehaviour).enabled = true;
		}
	}

	void Update () {
		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && playerInRange/*enemyHealth.currentHealth > 0*/) {
			Attack ();
		}

		if (playerHealth.currentHealth <= 0) {
			anim.SetTrigger ("Dead");
		}
	}

	void Attack () {
		timer = 0f;

		if (playerHealth.currentHealth > 0) {
			playerHealth.TakeDamage (attackDamage);
		}
	}
}