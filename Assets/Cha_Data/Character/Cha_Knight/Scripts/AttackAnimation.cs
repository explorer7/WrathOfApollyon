using UnityEngine;
using System.Collections;

public class AttackAnimation : MonoBehaviour {
    object knight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
            
        if (Practicemove.moving == true)
        {
            this.GetComponent<Animation>().Play("Walk");
        }

		else if (Input.GetMouseButton(1))
		{
			this.GetComponent<Animation>().Play("Attack");
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

}
