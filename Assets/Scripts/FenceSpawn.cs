using UnityEngine;
using System.Collections;

public class FenceSpawn : MonoBehaviour {

	public GameObject Prefab;


	// Use this for initialization
	void Start () {
		for (int i = 0; i < 33; i++) 
		{
			Instantiate (Prefab, new Vector3 ( -25, 3, transform.position.z + (i * 6)), Quaternion.identity); 
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
