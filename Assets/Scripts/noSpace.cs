using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class noSpace : MonoBehaviour {

    public int timer = 120;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer--;
	    if(timer <= 0)
        {
            //Application.LoadLevel("Game_Selector");
			SceneManager.LoadScene ("Game_Selector");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Application.LoadLevel("Game_Selector_Fail");
			SceneManager.LoadScene ("Game_Selector_Fail");
        }
	}
}
