using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RPSGame : MonoBehaviour {

	public GameObject opt1;
	public GameObject opt2;
	public GameObject opt3;

	public Sprite fist;
	public Sprite siccors;
	public Sprite paper;

	public GameObject otherhand;
	public GameObject selector;

	private int choice;
	private float choicetimer = 1f;


	// Use this for initialization
	void Start () {
		choice = (int) Random.Range(1f,4f);

		switch (choice) {
			case 1: {
					otherhand.GetComponent<SpriteRenderer> ().sprite = fist;
					break;
				}
			case 2: {
					otherhand.GetComponent<SpriteRenderer> ().sprite = siccors;
					break;
				}
			case 3: {
					otherhand.GetComponent<SpriteRenderer> ().sprite = paper;
					break;
				}
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (choicetimer.ToString());

		if (Input.GetButton("Space")) {
			if ( (choice == 1) && (selector.transform.position.x == 5) ) {
				SceneManager.LoadScene ("Game_Selector");
			} else if ( (choice == 2) && (selector.transform.position.x == 0) ) {
				SceneManager.LoadScene ("Game_Selector");
			} else if ( (choice == 3) && (selector.transform.position.x == -5) ) {
				SceneManager.LoadScene ("Game_Selector");
			} else {
				SceneManager.LoadScene ("Game_Selector_Fail");
			}
		}

		if (choicetimer <= 0) {
			// move to next
			if (selector.transform.position.x == 0){
				selector.transform.position = new Vector3 (5, -1, 0);
			} else if (selector.transform.position.x == 5){
				selector.transform.position = new Vector3 (-5, -1, 0);
			} else if (selector.transform.position.x == -5){
				selector.transform.position = new Vector3 (0, -1, 0);
			}
			choicetimer = 1f;
		}

		choicetimer -= Time.deltaTime;
	
	}
}
