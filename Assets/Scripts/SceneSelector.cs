using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour {


	private float currentTime = .5f;
	private int displayedTime = 3;
	public Text Counter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (displayedTime == 0) {
			SceneManager.LoadScene( Random.Range( 3, SceneManager.sceneCount ) );
		}

		if (currentTime < 0) {
			displayedTime -= 1;
			Counter.text = displayedTime.ToString();
			currentTime = .5f;

		} else {
			currentTime -= Time.deltaTime;
		}
	
	}
}
