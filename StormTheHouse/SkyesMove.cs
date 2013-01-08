using UnityEngine;
using System.Collections;

public class SkyesMove : MonoBehaviour
{
	public float Speed = 0f;
	public float RepeatTime = 0f;
	public float StartTime = 0F;
	public string LevelName;

	void Update ()
	{
		InvokeRepeating ("SkyMoving", StartTime, RepeatTime);
		
		if (transform.position.y <= -73) {			
			Application.LoadLevel (LevelName);
		}
	}
	
	void SkyMoving ()
	{
		transform.Translate (new Vector3 (0, 0, Speed * Time.deltaTime));
	}
}
