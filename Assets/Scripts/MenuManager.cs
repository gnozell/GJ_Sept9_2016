﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Space")) {
			PlayerPrefs.SetInt ("life", 3);
			PlayerPrefs.SetInt ("played", 0);
			SceneManager.LoadScene ("Game_Selector");
		}

		if (Input.GetButton("Escape")) {
			Application.Quit ();
		}
	
	}


}
