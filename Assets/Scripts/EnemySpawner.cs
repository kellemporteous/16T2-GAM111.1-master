using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemy;
	public float spawnTime = 3.0f;
	public Transform[] spawnPosition;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	// Update is called once per frame
	void Update () {

	}

	void Spawn ()
	{
		int spawnPositionIndex = Random.Range (0, spawnPosition.Length);

		Instantiate (enemy, spawnPosition[spawnPositionIndex].position, spawnPosition[spawnPositionIndex].rotation);
	}
}