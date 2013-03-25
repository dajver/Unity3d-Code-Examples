using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{
	public int speed = 10;
	public int targetRadius = 3;
	private Vector3 target;
	private Ray ray;
	private RaycastHit hit;
	
	void Start ()
	{
		rigidbody.freezeRotation = true;
		target = transform.position;
	}
	
	void Update ()
	{
		target.y = transform.position.y;
		if (Input.GetButtonDown ("Fire1")) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				target = hit.point;
				
			}
		}
		
		if(Vector3.Distance(transform.position, target) > targetRadius) {
			transform.LookAt(target);
			transform.Translate(0,0, speed * Time.deltaTime);
		}
	}
}
