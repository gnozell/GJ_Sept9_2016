using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelectorFail : MonoBehaviour {


	private float currentTime = .5f;
	private int displayedTime = 3;
	private bool showinghurt = true;
	private float hurttimer = 3f;
	public Text Counter;



	// Use this for initialization
	void Start () {
		Random.InitState ( (int)System.DateTime.Now.Ticks);

		//PlayerPrefs.SetInt ("life", 3);
		Counter.text = "";
		PlayerPrefs.SetInt ("life", PlayerPrefs.GetInt ("life") - 1);
		if (PlayerPrefs.GetInt ("life") <= 0) {
			Application.LoadLevel("Ending Menu");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(showinghurt){
			if (hurttimer <= 0) {
				showinghurt = false;
				Counter.text = "3";
			} else {
				Counter.text = "Life: " + (PlayerPrefs.GetInt ("life")-1).ToString();
			}
				
			hurttimer -= Time.deltaTime;
		} if (!showinghurt) {

			if (displayedTime == 0) {
				int Rnd = Random.Range (4, SceneManager.sceneCountInBuildSettings);
				SceneManager.LoadScene (Rnd);
			}

			if (currentTime < 0) {
				displayedTime -= 1;
				Counter.text = displayedTime.ToString ();
				currentTime = .5f;
			} else {
				currentTime -= Time.deltaTime;
			}
		}
	}
}
