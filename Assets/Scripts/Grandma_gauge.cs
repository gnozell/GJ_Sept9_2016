using UnityEngine;
using System.Collections;

public class Grandma_gauge : MonoBehaviour {

	public Grandma_Meter gmam;
	private float last_power = 0f;
	private float current_power = 0f;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		current_power = (gmam.GetComponent<Grandma_Meter>().powerlevel) - last_power;
		last_power = gmam.GetComponent<Grandma_Meter>().powerlevel;

		transform.RotateAround(new Vector3(7,1,0), Vector3.back, 2.5f*current_power);

	}
}
