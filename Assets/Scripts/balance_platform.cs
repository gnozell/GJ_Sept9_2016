using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class balance_platform : MonoBehaviour {

    Rigidbody2D rb;
    int direction = 1;
    public int timer = 0;
    // Use this for initialization
    void Start () {
            rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        timer++;
        if(timer >= 575)
        {
            //Application.LoadLevel("Game_Selector");
			SceneManager.LoadScene ("Game_Selector");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction *= -1;
        }

        rb.velocity = new Vector2(3f*direction, 0f);

        if (direction ==-1 && this.transform.position.x <= -6.8)
        {
            rb.velocity = new Vector2(0f, 0f);
        }
        if (direction == 1 && this.transform.position.x >= 6.8)
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
