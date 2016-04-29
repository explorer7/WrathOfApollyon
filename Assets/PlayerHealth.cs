using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	bool isDead;
	//bool damaged;
	Animator anim;
	private 

	void Awake () {
		//healthSlider = FindObjectOfType<Slider> ("HealthSlider");
		anim = GetComponent<Animator> ();
		currentHealth = startingHealth;
	}

	// Update is called once per frame
	void Update () {
		//damaged = false;
	}

	public void TakeDamage (int amount) {
		//damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if (currentHealth <= 0 && !isDead) {
			Death ();
		} else {
			anim.SetTrigger ("Damage");
		}
	}

	void Death () {
		isDead = true;

		anim.SetTrigger ("Dead");
		(GetComponent ("Practicemove") as MonoBehaviour).enabled = false;
	}
}