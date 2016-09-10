using UnityEngine;
using System.Collections;

public class Grandma_Meter : MonoBehaviour {


	public float powerlevel = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown("Space")) {
			powerlevel += 5f;
		}

		if (powerlevel < 0f) {
			powerlevel = 0f;
		} else if(powerlevel > 100f){
			Application.LoadLevel("Game_Selector");
		} else if (powerlevel != 0f ){
			powerlevel -= .25f;
		}
	}
}
