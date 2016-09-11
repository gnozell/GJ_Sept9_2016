using UnityEngine;
using System.Collections;

public class HammerGame : MonoBehaviour {

	private bool hammerdown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Space")) {
			hammerdown = true;
		} 
		if (Input.GetButtonUp ("Space")) {
			hammerdown = false;
		} 

		if (hammerdown) {
			// Rotate Hammer 0 0 30
			transform.eulerAngles = new Vector3(0f,0f,30f);
		} else {
			// Rotation 0 0 0
			transform.eulerAngles = new Vector3(0f,0f,0f);
			
		}


	}
}
