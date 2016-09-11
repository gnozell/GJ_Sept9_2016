using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingMenu : MonoBehaviour {

	public Text DemotivationalMessage;
	public Text Score;

	// Use this for initialization
	void Start () {
		Score.text = "Score: " + PlayerPrefs.GetInt ("played").ToString ();

		PlayerPrefs.SetInt ("played", 0);
		PlayerPrefs.SetInt ("life", 3);

		int rnd = (int) Random.Range(0f,10f);
		switch (rnd) {

		case 1:
			{
				DemotivationalMessage.text = "You Lose";
				break;
			}
		case 2:
			{
				DemotivationalMessage.text = "You Suck";
				break;
			}
		case 3:
			{
				DemotivationalMessage.text = "You Stink";
				break;
			}
		case 4:
			{
				DemotivationalMessage.text = "GGWP";
				break;
			}
		case 5:
			{
				DemotivationalMessage.text = "Thanks4Playing";
				break;
			}
		case 6:
			{
				DemotivationalMessage.text = "Fin.";
				break;
			}
		case 7:
			{
				DemotivationalMessage.text = "Neato";
				break;
			}
		case 8:
			{
				DemotivationalMessage.text = "Lol";
				break;
			}
		case 9:
			{
				DemotivationalMessage.text = "GGWP EZ";
				break;
			}
		case 10:
			{
				DemotivationalMessage.text = "Git Gud";
				break;
			}
		default:
			{
				DemotivationalMessage.text = "This Blows";
				break;
			}
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Space")) {
			//Application.LoadLevel("Main Menu");
			SceneManager.LoadScene ("Main Menu");
		}

		if (Input.GetButton("Escape")) {
			Application.Quit ();
		}

	}
}
