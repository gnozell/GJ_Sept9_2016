using UnityEngine;
using System.Collections;

public class RunnerGame : MonoBehaviour {

	private Rigidbody2D runnerbod;
	private float cSpeed = 30f;
	private float maxSpeed = 10f;
	

	// Use this for initialization
	void Start () {
		runnerbod = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetButtonDown("Space")) {
			runnerbod.AddForce (new Vector2 (0, 10f), ForceMode2D.Impulse);
		}
		runnerbod.AddForce (new Vector2 (1 * cSpeed, 0));

		if (Mathf.Abs(runnerbod.velocity.x) > maxSpeed) {
			runnerbod.AddForce (new Vector2 (-1 * cSpeed, 0));
		}
	
	}

	void OnTriggerEnter2D(Collider2D col){
		Application.LoadLevel("Game_Selector");
	}
}
