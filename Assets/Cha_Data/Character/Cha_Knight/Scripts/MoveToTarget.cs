using UnityEngine;
using System.Collections;

public class MoveToTarget : MonoBehaviour {

	public Transform goTarget;
	public float speed = 10;
	public static bool moving = false;
	
	void Update () 
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards
			(transform.position, goTarget.position, step);

		if (transform.position != goTarget.position) {
			moving = true;
		} else if (transform.position == goTarget.position) {
			moving = false;
		}
	}
}

