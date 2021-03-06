﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RunnerGame : MonoBehaviour {

	private Rigidbody2D runnerbod;
	private float cSpeed = 30f;
	private float maxSpeed = 10f;
	

	// Use this for initialization
	void Start () {
		runnerbod = GetComponent<Rigidbody2D> ();
	
	}


	void Update(){
		if (Input.GetButtonDown("Space")) {
			runnerbod.AddForce (new Vector2 (0, 10f), ForceMode2D.Impulse);
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		runnerbod.AddForce (new Vector2 (1 * cSpeed, 0));

		if (Mathf.Abs(runnerbod.velocity.x) > maxSpeed) {
			runnerbod.AddForce (new Vector2 (-1 * cSpeed, 0));
		}
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Finish") {
			//Application.LoadLevel ("Game_Selector");
			SceneManager.LoadScene ("Game_Selector");
		} else {
			//Application.LoadLevel ("Game_Selector_Fail");
			SceneManager.LoadScene ("Game_Selector_Fail");
		}
	}
}
