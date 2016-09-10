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
        timer = 40;
        typed_text.text = sentences[i][letterNum].ToString();
        letterNum++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(sentences[i][letterNum] == ' ')
            {
                typed_text.text += sentences[i][letterNum].ToString();
                letterNum++;
                typed_text.text += sentences[i][letterNum].ToString();
                letterNum++;
                timer = 40;
            } else if(sentences[i][letterNum-1] != ' ')
            {
                Application.LoadLevel("Game_Selector_Fail");
            }
        } else if (timer == 1 && (sentences[i][letterNum] == ' '))
        {
           Application.LoadLevel("Game_Selector_Fail");
        }

        if (timer <= 0)
        {
            typed_text.text += sentences[i][letterNum].ToString();
            letterNum++;
            if(letterNum >= sentences[i].Length)
                Application.LoadLevel("Game_Selector");
            timer = 40;
            if (sentences[i][letterNum] == ' ') timer = 60;
        } 
        timer--;
    }
}