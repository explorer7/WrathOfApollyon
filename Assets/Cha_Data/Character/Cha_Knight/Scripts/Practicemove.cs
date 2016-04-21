using UnityEngine;
using System.Collections;

public class Practicemove : MonoBehaviour {
	public Transform goTarget;
	public float speed = 10;
	public static bool moving = false;

	void Update () 
	{
		
		float step2 = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards
			(transform.position, goTarget.position, step2);

		if (transform.position != goTarget.position) {
			moving = true;
		} else if (transform.position == goTarget.position) {
			moving = false;
		}

		Vector3 targetDir = goTarget.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay (transform.position, newDir, Color.red);
		transform.rotation = Quaternion.LookRotation (newDir);
	
	}
}
