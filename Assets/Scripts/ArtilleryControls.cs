using UnityEngine;
using System.Collections;

public class ArtilleryControls : MonoBehaviour {


	public float rotationSpeed = 10.0f;

	public GameObject launcher;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Up and Down Rotation
		if (Input.GetKey ("w")) {
			launcher.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
		}else if (Input.GetKey ("s")) {
			launcher.transform.Rotate (Vector3.forward * rotationSpeed * Time.deltaTime);
		}

		//Left and Right Rotation
		if (Input.GetKey ("a")) {
			transform.Rotate (Vector3.up * -rotationSpeed * Time.deltaTime);
		}else if (Input.GetKey ("d")) {
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);
		}
	}
}
