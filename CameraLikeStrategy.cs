using UnityEngine;
using System.Collections;

public class CameraLikeStrategy : MonoBehaviour
{
	public int Boundary = 50; // distance from edge scrolling starts
	public int speed = 5;
	private int theScreenWidth;
	private int theScreenHeight;
	// Use this for initialization
	void Start ()
	{
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.mousePosition.x > theScreenWidth - Boundary) {
			var pos = transform.position;
			pos.x +=  speed * Time.deltaTime;
			transform.position = pos; // move on +X axis
		}
 
		if (Input.mousePosition.x < 0 + Boundary) {
			var pos = transform.position;
			pos.x -=  speed * Time.deltaTime;
			transform.position = pos; // move on -X axis
		}
 
		if (Input.mousePosition.y > theScreenHeight - Boundary) {
			var pos = transform.position;
			pos.y +=  speed * Time.deltaTime;
			transform.position = pos; // move on +Z axis
		}
 
		if (Input.mousePosition.y < 0 + Boundary) {
			var pos = transform.position;
			pos.y -=  speed * Time.deltaTime;
			transform.position = pos; // move on -Z axis
		}
	}
}
