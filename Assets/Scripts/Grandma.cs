using UnityEngine;
using System.Collections;

public class Grandma : MonoBehaviour {

	private float totaltime = 0f;
	private bool rot = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (rot) {
			transform.Rotate (0, 0, Time.deltaTime * 20);

		} else {
			transform.Rotate (0, 0, Time.deltaTime * -20);
		}

		if (totaltime > .5f) {
			rot = !rot;
			totaltime = 0f;
		}

		totaltime += Time.deltaTime;

	
	}
}
