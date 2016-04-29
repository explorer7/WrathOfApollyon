using UnityEngine;
using System.Collections;

public class AttackAnimation : MonoBehaviour {

	public int damagePerSwing = 10;
	public float timeBetweenSwings = 20.0f;
	//Animator anim;
	EnemyHealth enemyHealth;
	GameObject Enemy;
	public bool enemyInRange;
	float timer;

	void Awake () {
		//anim = GetComponent<Animator> ();
		Enemy = GameObject.FindGameObjectWithTag("Enemy");
		enemyHealth = Enemy.GetComponent<EnemyHealth> ();
	}

	// Update is called once per frame
	void Update () {
		//timer += Time.deltaTime;
            
        if (Practicemove.moving == true)
        {
            this.GetComponent<Animation>().Play("Walk");
        }

		else if (Input.GetMouseButton(1) /*&& timer >= timeBetweenSwings*/)
		{
			this.GetComponent<Animation>().Play("Attack");
			Attack ();
		}
		else if(Input.GetKey("x")) 
		{
			this.GetComponent<Animation>().Play("Dead");
		}
		else if(Input.GetKey("z")) 
		{
			this.GetComponent<Animation>().Play("Damage");
		}
        else
        {
            this.GetComponent<Animation>().Play("Wait");
        }


    } 

	void Attack () {
		//timer = 0f;
		if (enemyInRange == true) {
			enemyHealth.TakeDamage (damagePerSwing);
		}
		//anim.Play("Attack");
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject == Enemy) {
			enemyInRange = true;
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.gameObject == Enemy) {
			enemyInRange = false;
		}
	}
}
