using UnityEngine;
using System.Collections;

public class text_decay : MonoBehaviour {

	public int timer = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer--;
		if(timer<=0) Destroy(this.gameObject);
	}
}
