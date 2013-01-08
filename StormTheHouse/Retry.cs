using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("LevelOne");
		}
	}
}
