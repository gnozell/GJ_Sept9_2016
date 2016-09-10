using UnityEngine;
using System.Collections;

public class red_light_green_light : MonoBehaviour {

    int lightX = -3;
    int lightY = 0;
    public int timer = 0;
    public int timerMax = 75;
    //state 1 is green
    //state -1 is red
    int state = 1;
    public GameObject redLight;
    public GameObject greenLight;
    GameObject currentLight;
    public GameObject red_bar;
    float barLength = 1;

	// Use this for initialization
	void Start ()
    {
        currentLight = (GameObject)Instantiate(greenLight, new Vector2(lightX, lightY), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        if (barLength >= 30)
            Application.LoadLevel("Game_Selector");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(state == 1)
            {
                barLength += 1f;
            } else if(timer >= 20)
            {
                Application.LoadLevel("Game_Selector_Fail");
            }
        }

        barLength -= .05f;

        if (barLength < 0) barLength = 0;

        red_bar.transform.localScale = new Vector3(1, barLength, 1);

	    if(timer >= timerMax)
        {
            timer = 0;
            timerMax = (int)Random.Range(0, 300);
            state *= -1;
            Destroy(currentLight);
            if(state == 1)
            {
                currentLight = (GameObject)Instantiate(greenLight, new Vector2(lightX, lightY), Quaternion.identity);
            } else {
                currentLight = (GameObject)Instantiate(redLight, new Vector2(lightX, lightY), Quaternion.identity);
            }
        }
        timer++;
	}
}
