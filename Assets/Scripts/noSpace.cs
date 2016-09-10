using UnityEngine;
using System.Collections;

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
            Application.LoadLevel("Game_Selector");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("Game_Selector");
        }
	}
}
