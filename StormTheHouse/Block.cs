using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
	public float MaxHealth = 100f;
	float _health;
	float healthBarLength;

	void Start ()
	{
		_health = MaxHealth;
		healthBarLength = Screen.width / 4;
	}
	
	public void ChangeHealth (float damage)
	{
		_health -= damage;
		if (_health <= 2f) {
			//Application.LoadLevel ("GameOver");
		}
		healthBarLength = (Screen.width / 4) * (_health / MaxHealth);
	}
	
	void OnGUI ()
	{
		GUI.Box (new Rect (10, 10, healthBarLength, 20), _health + " / " + MaxHealth + " Fence");
	}
}
