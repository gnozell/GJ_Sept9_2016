using UnityEngine;
using System.Collections;

public class SpiderAI : MonoBehaviour {

	private Rigidbody2D runnerbod;
	private float cSpeed = 30f;
	private float maxSpeed = 10f;


	// Use this for initialization
	void Start () {
		runnerbod = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {

		runnerbod.AddForce (new Vector2 (1 * cSpeed, 0));

		if (Mathf.Abs(runnerbod.velocity.x) > maxSpeed) {
			runnerbod.AddForce (new Vector2 (-1 * cSpeed, 0));
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		cSpeed = -cSpeed;
		if (col.tag == "Player") {
			Destroy (gameObject);
		}
	}

}
