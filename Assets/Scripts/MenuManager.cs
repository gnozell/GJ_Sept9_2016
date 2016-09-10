using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Space")) {
			PlayerPrefs.SetInt ("life", 3);
			Application.LoadLevel("Game_Selector");
		}
	
	}


}
