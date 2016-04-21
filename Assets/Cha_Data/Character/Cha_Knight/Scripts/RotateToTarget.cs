using UnityEngine;
using System.Collections;

public class RotateToTarget : MonoBehaviour {
	public Transform turnTarget;
	public float speed = 10;

	void Update () 
	{
		Vector3 targetDir = turnTarget.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay (transform.position, newDir, Color.red);
		transform.rotation = Quaternion.LookRotation (newDir);

		//transform.LookAt (turnTarget);
	
	}
}
