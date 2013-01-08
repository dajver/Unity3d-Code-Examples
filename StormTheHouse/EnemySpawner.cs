using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	private int speed = 5;
	public GameObject EnemyPrefab;
	public float DelayBetweenSpawns = 2f;
	float _nextSpawnTime;

	void Update ()
	{
		if (transform.position.y <= -21) {
			transform.position = new Vector3 (transform.position.x, 2f, transform.position.z);
		}		
		transform.Translate (0, 0, speed * Time.deltaTime);
		
		if (Time.time >= _nextSpawnTime) {
			_nextSpawnTime = Time.time + DelayBetweenSpawns;
			Instantiate (EnemyPrefab, transform.position, transform.rotation);
		}
	}
}
