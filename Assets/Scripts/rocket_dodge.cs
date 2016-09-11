using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class rocket_dodge : MonoBehaviour {

	public int timer;
	public int spaceDown = -1;
	public GameObject player;
	public GameObject splosion;
	public GameObject textSpace;
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject textGo;

	Rigidbody2D rb;
	int gamestate = 1;

	// Use this for initialization
	void Start () {
		timer = 120;
		//Instantiate (textSpace, new Vector3 (0f, 0f, -1f), Quaternion.identity);
		//Instantiate (text3, new Vector3 (0f, -1.92f, -1f), Quaternion.identity);
		player = this.gameObject;
		rb = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//Gamestate 0 is intro
		//Gamestate 1 is play
		//Gamestate 2 is success
		//Gamestate 3 is failure

		if (gamestate == 0) {
			if (timer > 0)
				timer--;
			if (timer == 90) 
				Instantiate (text2, new Vector3 (0f, -2.27f, -1f), Quaternion.identity);
			if (timer == 60)
				Instantiate (text1, new Vector3 (0f, -2.27f, -1f), Quaternion.identity);
			if (timer == 30)
				Instantiate (textGo, new Vector3 (0f, 0f, -1f), Quaternion.identity);
			if (timer <= 0)
				gamestate = 1;
		} else if (gamestate == 1) {
			if (this.gameObject.transform.position.x >= 8.25)
				gamestate = 2;
			if (Input.GetKey (KeyCode.Space)) {
				spaceDown = 1;
			} else
				spaceDown = -1;
			rb.AddForce (new Vector2 (1, 5 * spaceDown));
		} else if (gamestate == 2) {
            //Application.LoadLevel("Game_Selector");
			SceneManager.LoadScene ("Game_Selector");

        } else if (gamestate == 3) {
            //Application.LoadLevel("Game_Selector_Fail");
			SceneManager.LoadScene ("Game_Selector_Fail");
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
        gamestate = 3;
		Instantiate (splosion, this.gameObject.transform.position, this.gameObject.transform.rotation);
	}

}
