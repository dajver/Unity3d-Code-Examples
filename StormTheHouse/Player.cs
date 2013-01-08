using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public GameObject bulletPrefab;
	Ray ray;
	RaycastHit hit;
	//бабулесы
	public float Money = 0;
	//обойма
	public int cage = 7;
	//текущая обойма
	public int currentCage = 7;
	
	void Update ()
	{
		ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
		//проверка на клик
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hit, 1000)) {
				if (hit.collider.gameObject.name == "Weapon-bg") {
					currentCage -= 1;
					if (currentCage <= 0) {
						currentCage = 0;	
					} else {
						// страх и ужас
					}	
				} else {
					//проверка коснулись ли врага
					if (hit.collider.gameObject.name == "Enemy") {
						Debug.Log("Enemy");
						GameObject bombObject = Instantiate (bulletPrefab) as GameObject;
						var pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
						pos.z = 0f;
						bombObject.transform.position = pos;
						Destroy (bombObject, 0.5f);
					}
				}
			}
		}
		
		if (Input.GetKeyDown ("space"))
			currentCage = cage;
	}
	
	void OnGUI ()
	{
		GUI.Box (new Rect (365, 10, 150, 20), " $" + Money);
		GUI.Box (new Rect (520, 10, 150, 20), cage + " / " + currentCage);
	}
}
