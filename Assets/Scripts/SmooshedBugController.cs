using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SmooshedBugController : MonoBehaviour {

	public GameObject s1;
	public GameObject s2;
	public GameObject s3;
	public GameObject s4;
	public GameObject s5;


	private float timer = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((s1 == null) &&(s2 == null) &&(s3 == null) &&(s4 == null) &&(s5 == null)){
			SceneManager.LoadScene ("Game_Selector");
			
		}

		if (timer <= 0) {
			SceneManager.LoadScene ("Game_Selector_Fail");
		}

		timer -= Time.deltaTime;
		
	
	}
}
