﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Grandma_Meter : MonoBehaviour {

	public float timer = 8f;
	public float powerlevel = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown("Space")) {
			powerlevel += 10f;
		}

		if (powerlevel < 0f) {
			powerlevel = 0f;
		} else if(powerlevel > 100f){
			//Application.LoadLevel("Game_Selector");
			SceneManager.LoadScene ("Game_Selector");
		} else if (powerlevel != 0f ){
			powerlevel -= .25f;
		}

		timer -= Time.deltaTime;
		if (timer <= 0) {
			//Application.LoadLevel("Game_Selector_Fail");
			SceneManager.LoadScene ("Game_Selector_Fail");
		}
	}
}
