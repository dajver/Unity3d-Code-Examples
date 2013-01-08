using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	public float Speed = 10f;
	public float Damage = 1f;
	public float MaxHealth = 100f;
	float _health;
	public GameObject fence;
	public Transform target;
	public float Timer = 0.02f;
	
	void Start ()
	{
		_health = MaxHealth;
	}

//	void OnGUI ()
//	{
//		Camera cam = Camera.main;
//		Vector3 screenPos = cam.WorldToScreenPoint (target.position);
//		GUI.Box (new Rect (screenPos.x - _health / 2, Screen.height - screenPos.y - 25, _health, 5), "");
//	}
	
	void Update ()
	{
		transform.Translate (new Vector3 (-Speed * Time.deltaTime, 0, 0));
	}
	
	public void ChangeHealth (float damage)
	{
		_health -= damage;
		if (_health <= 0f) {
			GameObject go = GameObject.Find ("House");
			Player sc = (Player)go.GetComponent (typeof(Player));
			sc.Money += 100;
			MoveSprites ms = GetComponent<MoveSprites> ();
			ms.AnimationPlayNumber = 2;
			Speed = 0f;
			Destroy(gameObject, 0.5f);
		}
	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Fence") {
			Speed = 0f;
			MoveSprites ms = GetComponent<MoveSprites> ();
			ms.AnimationPlayNumber = 1;
			InvokeRepeating ("FenceAttack", 0f, 1f);
		}
		
		if (other.tag == "Blood") {
			ChangeHealth (50);
		}
	}
	
	void FenceAttack ()
	{
		fence.GetComponent<Block> ().ChangeHealth (Damage);
	}
}
