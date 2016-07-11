using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	GameManager gameManager;

	public GameObject[] muzzles;

	public GameObject projectile;
	public float projectileFireRate = 1.0f;
	public float projectileFireTime;


	// Use this for initialization
	void Start () 
	{
		gameManager = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		FireProjectile ();
	}

	public void FireProjectile ()
	{
		if (Input.GetMouseButton (0) && Time.time > projectileFireTime) 
		{
			for (int index = 0; index < muzzles.Length; ++index) 
			{
				Instantiate (projectile, muzzles [index].transform.position, muzzles [index].transform.rotation);
			}
			projectileFireTime = Time.time + projectileFireRate;
		}
	}
}
