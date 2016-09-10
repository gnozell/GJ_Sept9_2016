using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public int get_life(){
		return PlayerPrefs.GetInt ("life");
	}

	public void next_game(){
		
	}

	public void set_life(int life){
		PlayerPrefs.SetInt ("life", life);
	}

	public void hurt_life(int hurt){
		PlayerPrefs.SetInt ("life", PlayerPrefs.GetInt ("life") - 1);
		if (PlayerPrefs.GetInt ("life") <= 0) {
			end_game ();
		}
	}

	public void end_game(){
		Application.LoadLevel("Ending Menu");
	}

	public void to_menu(){
		Application.LoadLevel("Main Menu");
	}


}
