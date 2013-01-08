using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public int speed = 5;
	public int gravity = 5;
	private CharacterController cc;
	
	void Start ()
	{
		cc = GetComponent<CharacterController> ();
	}
	
	void Update ()
	{
		if (cc != null) {
			if (networkView.isMine) {
				cc.Move (new Vector3 (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, -gravity * Time.deltaTime, Input.GetAxis ("Vertical") * speed * Time.deltaTime));
			}
		}
	}
}
