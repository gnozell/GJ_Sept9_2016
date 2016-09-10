using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndingMenu : MonoBehaviour {

	public Text DemotivationalMessage;

	// Use this for initialization
	void Start () {

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
				DemotivationalMessage.text = "Thanks for Playing";
				break;
			}
		case 6:
			{
				DemotivationalMessage.text = "Fin.";
				break;
			}
		case 7:
			{
				DemotivationalMessage.text = "Wow that was fast";
				break;
			}
		case 8:
			{
				DemotivationalMessage.text = "You need more Practice";
				break;
			}
		case 9:
			{
				DemotivationalMessage.text = "GGWP EZ";
				break;
			}
		case 10:
			{
				DemotivationalMessage.text = "Git Gud Scrub";
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
			Application.LoadLevel("Main Menu");

		}

	}
}
