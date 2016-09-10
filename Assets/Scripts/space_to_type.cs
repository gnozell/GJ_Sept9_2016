using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class space_to_type : MonoBehaviour {

	public int i;
	string[] sentences = {
		"Welcome to the Space Jam",
		"Release the Kraken",
        "Call me Ishmael",
        "Let me smell thine hair",
        "Come back son we miss you"
    };
    string toBeTyped;
	public Text typed_text;
	public int timer;
    int letterNum = 0;

	// Use this for initialization
	void Start ()
    {
        i = (int)Random.Range(0, 200) % 5;
        timer = 60;
        //(toBeTyped.ToCharArray())[letterNum] = (sentences[i].ToCharArray())[letterNum];
    }

    // Update is called once per frame
    void Update()
    {
        //typed_text.text = sentences[2].
        if (timer-- <= 0)
        {
            letterNum++;
            //(toBeTyped.ToCharArray())[letterNum] = (sentences[i].ToCharArray())[letterNum];
            timer = 60;
        }
    }
}